using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_client
{
    public partial class Form1 : Form
    {
        string URL = "http://localhost/REST_server/";
        string ROUTE ="index.php";

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAll_btn_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                var client = new RestClient(URL);
                var request = new RestRequest(ROUTE, Method.GET);

                IRestResponse<List<Book>> response = client.Execute<List<Book>>(request);
                listBox1.Items.Add("All Books:");
                foreach (Book b in response.Data)
                {
                    listBox1.Items.Add("ID: " + b.id + " - " + b.price + "$ " + b.title + "(" + b.yearOfRelease + ") - " + b.author);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetGameById_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(URL);
                string ROUTE = "index.php?id=" + get_book_by_id_numeric.Value;
                var request = new RestRequest(ROUTE, Method.GET);

                listBox1.Items.Clear();

                if (get_book_by_id_numeric.Value != 0)
                {
                    listBox1.Items.Add("Book by id:" + get_book_by_id_numeric.Value);
                }
                else
                {
                    listBox1.Items.Add("All books:");
                }


                IRestResponse<List<Book>> response = client.Execute<List<Book>>(request);
                foreach (Book b in response.Data)
                {
                    listBox1.Items.Add("ID: " + b.id + " - " + b.price + "$ " + b.title + "(" + b.yearOfRelease + ") - " + b.author);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            string ROUTE = "index.php/{id}{password}";
            var request = new RestRequest(ROUTE, Method.DELETE);

            request.AddParameter("id",delete_id_numeric.Value);
            request.AddParameter("password", password_box.Text);

            IRestResponse response = client.Execute(request);
            MessageBox.Show("Book Deletion Request Sent");

            GetAll_btn_Click(sender, e);

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {

            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);
            request.RequestFormat = DataFormat.Json;

            try
            {
                request.AddBody(new Book
                {
                    title = title_tb.Text,
                    author = author_tb.Text,
                    price = (int)insert_price_numeric.Value,
                    yearOfRelease = Convert.ToInt32(insert_year.Text)
                });

                IRestResponse response = client.Execute(request);
                MessageBox.Show("Book Insertion Request Sent");
                GetAll_btn_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Missing data");
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.PUT);
            request.RequestFormat = DataFormat.Json;

            try
            {
                request.AddBody(new Book
                {
                    id = (int)id_update_numeric.Value,

                    title = title_update_tb.Text != "" ? title_update_tb.Text : "-1",
                    author = author_update_tb.Text != "" ? author_update_tb.Text : "-1",
                    price = price_update_numeric.Value != 0 ? (int)price_update_numeric.Value : -1,
                    yearOfRelease = update_year.Text != "" ? Convert.ToInt32(update_year.Text) : -1,
                    password = password_box.Text
                });

                IRestResponse response = client.Execute(request);
                MessageBox.Show("Book Update Request Sent");
                GetAll_btn_Click(sender, e);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
