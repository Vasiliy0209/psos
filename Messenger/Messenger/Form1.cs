using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookComputing.XmlRpc;

namespace Messenger
{
    public partial class Form1 : Form
    {
        public struct LJPostEventArg
        {
            public string username;
            public string password;
            [XmlRpcMember("event")]
            public string ljevent;
            public string lineendings;
            public string subject;
            public int year;
            public int mon;
            public int day;
            public int hour;
            public int min;
        }

        public struct LJRetVal
        {
            public int itemid;
            public int anum;
            public string url;
        }

        [XmlRpcUrl("http://www.livejournal.com/interface/xmlrpc")]
        public interface ILJService
        {
            [XmlRpcMethod("LJ.XMLRPC.postevent")]
            LJRetVal postevent(LJPostEventArg posteventarg);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YandexSpeller.SpellService cl = new YandexSpeller.SpellService();
            YandexSpeller.SpellError[] errors = cl.checkText(tb_Post.Text,"ru",0,"");

            if(errors.Length !=0)
            {
                string message = "", variants = "";
                foreach (YandexSpeller.SpellError err in errors)
                {
                    foreach (string variant in err.s)
                        variants += variant + "\n";
                    message += "Слово [" + err.word + "]\nВозможные варианты:\n" + variants;
                }
                //Вывод сообщения пользователю
                MessageBox.Show(message);
                MessageBox.Show("Плохо писать нехорошо");
                return;
            }

            ILJService service = XmlRpcProxyGen.Create<ILJService>();
            LJPostEventArg arg = new LJPostEventArg();

            arg.day = DateTime.Now.Day;
            arg.hour = DateTime.Now.Hour;
            arg.min = DateTime.Now.Minute;
            arg.mon = DateTime.Now.Month;
            arg.year = DateTime.Now.Year;

            arg.username = "inf_study";
            arg.password = "do520xLpim4";
            arg.lineendings = "pc";

            arg.subject = tb_Subject.Text;
            arg.ljevent = tb_Post.Text;

            try
            {
                LJRetVal ret = service.postevent(arg);
                MessageBox.Show("Сообщение успешно опубликовано [" + ret.url + "]");
            }
            catch(XmlRpcIllFormedXmlException ex)
            {
                MessageBox.Show("Сообщение не опубликованно. Ошибка [" + ex.Message + "]");
            }

            
            
            /*catch()
            {
                MessageBox.Show("Сообщение не опубликованно. Неизвестная ошибка.");
            }*/

        }
    }
}
