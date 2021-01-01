using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Haberler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Assembly current = Assembly.GetExecutingAssembly();


            Type[] types = current.GetTypes();

            foreach(Type type in types)
            {
                if(type.BaseType == typeof(AnaHaber))
                {
                    object obj = Activator.CreateInstance(type);
                    cbKanallar.Items.Add(obj);
                }
            }
        }



        private void cbKanallar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHaberler.Items.Clear();
            string oku = cbKanallar.Items[cbKanallar.SelectedIndex].GetType().GetProperties().First(x => x.Name == "Link").GetValue(cbKanallar.Items[cbKanallar.SelectedIndex], null).ToString();

            Feed feed = FeedReader.Read(oku);


            foreach (FeedItem item in feed.Items)
            {
                Haberler haber = new Haberler();
                haber.Title = item.Title;
                haber.Link = item.Link;
                haber.Description = item.Description;
                haber.Image = item.SpecificItem.Element.Element("image").Value;
                lstHaberler.Items.Add(haber);

            }
        }

        private void lstHaberler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Haberler haber = (Haberler)lstHaberler.SelectedItem;
            NewsPhoto.Load(haber.Image);
            lblDescription.Text = haber.Description;
        }
    }
}
