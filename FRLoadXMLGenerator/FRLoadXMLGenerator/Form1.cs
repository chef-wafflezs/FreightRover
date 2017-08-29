using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace FRLoadXMLGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostLoadsRequest request = new PostLoadsRequest();
            request.Authentication = new Authentication();
            request.Authentication.Username = "sysadmin@freightrover.com";
            request.Authentication.Password = "Fr31ghtR0v3r!";

            request.TransactionID = "64c0ff56-66d3-4d9b-9321-8d1681e86ee3";
            request.LoadVisibility = "";

            var shipper = new LoadEntity()
            {
                Address1 = "1234"
            };

            var loads = new List<Load>();
            loads.Add(new FRLoadXMLGenerator.Load()
            {
                LoadId = "3",
                Shipper = shipper
            });

            request.Loads = loads;

            XmlSerializer SerializerObj = new XmlSerializer(typeof(PostLoadsRequest));
            TextWriter WriteFileStream = new StreamWriter(@"C:\Users\jmcbr\Desktop\loads.xml");

            SerializerObj.Serialize(WriteFileStream, request);
            WriteFileStream.Close();
            //saveFileDialog1.ShowDialog();

            //var test = destAddress.Text;
            //Debug.WriteLine(test);

            //var filename = saveFileDialog1.FileName + ".xml";
            //XmlWriter xmlWriter = XmlWriter.Create(filename);

            //xmlWriter.WriteStartDocument();
            //xmlWriter.WriteStartElement("PostLoadsRequest");

            //xmlWriter.WriteStartElement("Authentication");

            //xmlWriter.WriteStartElement("Username");
            //xmlWriter.WriteString("sysadmin@freightrover.com");
            //xmlWriter.WriteEndElement();

            //xmlWriter.WriteStartElement("Password");
            //xmlWriter.WriteString("Fr31ghtR0v3r!");
            //xmlWriter.WriteEndElement();

            //xmlWriter.WriteEndElement();

            //xmlWriter.WriteStartElement("TransactionID");
            //xmlWriter.WriteString("64c0ff56-66d3-4d9b-9321-8d1681e86ee3");
            //xmlWriter.WriteEndElement();

            //xmlWriter.WriteStartElement("LoadsVisibility");
            //xmlWriter.WriteEndElement();

            //xmlWriter.WriteStartElement("Loads");
            //xmlWriter.WriteStartElement("Load");

            //for(var i = 0; i < Int32.Parse(numberOfLoads.Text); i++)
            //{
            //    xmlWriter.WriteStartElement("Load");

            //    xmlWriter.WriteStartElement("LoadID");
            //    xmlWriter.WriteString("2845949001");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("CreateDateTime");
            //    xmlWriter.WriteString("2017-12-09-03.22.46.045000");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("DocumentPurposeCode");
            //    xmlWriter.WriteString("A");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("MustRespondByDateTime");
            //    xmlWriter.WriteString("0 0");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("LastUpdateDateTime");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Currency");
            //    xmlWriter.WriteString("UD");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("PaymentMethod");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("DeclaredValue");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Shipper");

            //        xmlWriter.WriteStartElement("RefID");
            //        xmlWriter.WriteString("11111");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Name");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Country");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address1");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address2");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address3");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("City");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("State");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Zip");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Notes");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptStartDateTime");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptEndDateTime");
            //        xmlWriter.WriteEndElement();

            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("BillTo");
            //        xmlWriter.WriteStartElement("RefID");
            //        xmlWriter.WriteString("11111");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Name");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Country");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address1");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address2");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address3");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("City");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("State");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Zip");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Notes");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptStartDateTime");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptEndDateTime");
            //        xmlWriter.WriteEndElement();

            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Origin");

            //        xmlWriter.WriteStartElement("RefID");
            //        xmlWriter.WriteString("673108");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Name");
            //        xmlWriter.WriteString("RYDER INTEGRATED LOGISTICS");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Country");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address1");
            //        xmlWriter.WriteString("1201 Green Valley Rd Bldg");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address2");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address3");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("City");
            //        xmlWriter.WriteString("Beaver DM");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("State");
            //        xmlWriter.WriteString("WI");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Zip");
            //        xmlWriter.WriteString("53916");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Notes");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptStartDateTime");
            //        xmlWriter.WriteString("20170814-0900");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptEndDateTime");
            //        xmlWriter.WriteString("20170814-1245");
            //        xmlWriter.WriteEndElement();

            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Dest");

            //        xmlWriter.WriteStartElement("RefID");
            //        xmlWriter.WriteString("11111");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Name");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Country");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address1");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address2");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Address3");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("City");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("State");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Zip");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("Notes");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptStartDateTime");
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("ApptEndDateTime");
            //        xmlWriter.WriteEndElement();

            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Equipment");
            //    xmlWriter.WriteString("RF");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("ServiceType");
            //    xmlWriter.WriteString("N");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Miles");
            //    xmlWriter.WriteString("506");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Rate");
            //    xmlWriter.WriteString("985.32");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Commodity");
            //    xmlWriter.WriteString("Frozen VEGE");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("Weight");
            //    xmlWriter.WriteString("20240");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("WeightUOM");
            //    xmlWriter.WriteString("LB");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("LoadVisibility");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("LoadNotes");
            //    xmlWriter.WriteString("No specific load information at this time.");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("SegmentsInfo");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("ShippmentInfo");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteEndElement();
            //}


            //xmlWriter.WriteEndDocument();
            //xmlWriter.Close();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void numberOfLoads_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
