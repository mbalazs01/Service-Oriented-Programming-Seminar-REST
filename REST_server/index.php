<?php
include("connection.php");

$db = new dbObj();
$connection = $db->getConnection();
$request_method = $_SERVER["REQUEST_METHOD"];
$securityPassword = "bionicman";    
$currentYear = date("Y");       


switch($request_method){
    case 'GET': //Select
        if(!empty($_GET["id"])){
            $id = intval($_GET["id"]);
            get_book_by_id($id);
        }else
            get_all_books();
    break;

    case 'POST': //Insert
        insert_book();
    break;

    case 'PUT': //Update        KELL HOZZÁ JELSZÓ
        update_book();
    break;

    case 'DELETE': //Delete     KELL HOZZÁ JELSZÓ
        $id = intval($_GET["id"]);
        $password = strval($_GET["password"]);
        delete_book($id, $password);
    break;

    default:
     header("HTTP/1.0 405 Method Not Allowed");
    break;
}

function get_all_books(){
    global $connection;
    $query = "SELECT * FROM books";
    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_array($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);
}

function get_book_by_id($id=0){
    global $connection;
    $query = "SELECT * FROM books";
    if($id != 0) $query.= " WHERE id =".$id." LIMIT 1"; //
    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_array($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);

}

function insert_book(){
    global $connection;
    global $currentYear;

    $data = json_decode(file_get_contents('php://input'),true);
    $title = $data["title"];
    $author = $data["author"];
    $price = $data["price"];
    $yearOfRelease = $data["yearOfRelease"];

    $query = "INSERT INTO books SET yearOfRelease = ' ".$yearOfRelease." ', title =' ". $title." ', author =' ".$author." ',price=' ".$price." ' ";

    if($yearOfRelease <= $currentYear) {                            // Nem szeretnénk jövőbeli könyveket az adatbázisban
        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'book inserted successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'book insertion failed'
            );
        }
    }

    header('Content-Type: application/json');
    echo json_encode($response);
}

function update_book(){
    global $connection;
    global $securityPassword;
    global $currentYear;

    $data = json_decode(file_get_contents('php://input'),true);
    $id = $data["id"];
    $title = $data["title"];
    $author = $data["author"];
    $price = $data["price"];
    $yearOfRelease = $data["yearOfRelease"];
    $password = $data["password"];

    $someDataChanged = false;           // Fontos, hogy csak akkor küldjünk query-t, ha egyáltalán változik valami

    $query = "UPDATE books SET";        // Darabonként adjuk hozzá a query-hez, hogy mit UPDATE-ljen

    if($title != "-1") {                                // Kliensen keresztül ha -1 értéket küldünk a szerver ignorálni fogja
        $query = $query." title=' ".$title." ', ";
        $someDataChanged = true;
    }

    if($author != "-1") {
        $query = $query." author=' ".$author." ',";
        $someDataChanged = true;
    }

    if($price != "-1") {
        $query = $query." price=' ".$price." ',";
        $someDataChanged = true;
    }

    if($yearOfRelease != "-1" && $yearOfRelease <= $currentYear) {      // Nem szeretnénk jövőbeli könyveket az adatbázisban
        $query = $query." yearOfRelease=' ".$yearOfRelease." ',";
        $someDataChanged = true;
    }

    if(str_ends_with($query, ",")) {      // Töröljük ki az utolsó vesszőt
        $query = substr($query, 0, -1);
    }

    $query = $query." WHERE id ="$id;

    if($securityPassword == $password && $someDataChanged) {
        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'book updated successfully'
            );
        }
    }
    else{
        $response = array(
            'status' => 0,
            'status_message' => 'book update failed'
        );
    }
                 
    header('Content-Type: application/json');
    echo json_encode($response);
}

function delete_book($id, $password){
    global $connection;
    global $securityPassword;
    $query= "DELETE FROM books WHERE id = ".$id;

    if($securityPassword == $password) { 
        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'book deleted successfully'
            );
        }
    }
    else{
        $response = array(
            'status' => 0,
            'status_message' => 'book deletion failed'
        );
    }

    header('Content-Type: application/json');
    echo json_encode($response);
}