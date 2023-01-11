using System.Text.RegularExpressions;
namespace Kursovoi
{
	public partial class Form1 : Form
	{
		AbstractFactory factory;

		public Form1()
		{
			InitializeComponent();
			factory = new LoggingConcreteFactory();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Стартовые значения -- нужны для наглядной демонстрации
			comboBox1.SelectedIndex = 2;
			textBox.Text = "Группа 1[.]ПИ0[0]. Результаты сессии 1[оценка] 5 0[0] баллов.\n" +
				" Студенты 1[Максим] 4 1[Илья] 2 1[Ваня] 5 0[0]";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Выпадающий список
			if (comboBox1.SelectedIndex == 0)
			{
				nameLabel.Visible = false;
				nameBox.Visible = false;

				valueLabel.Visible = true;
				valueLabel.Text = "Значение:";
				valueBox.Visible = true;
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				nameLabel.Visible = true;
				nameBox.Visible = true;

				valueBox.Visible = true;
				valueLabel.Text = "Значение: ";

			}
			else if (comboBox1.SelectedIndex == 2)
			{
				nameLabel.Visible = true;
				nameBox.Visible = true;
				valueBox.Visible = false;
				valueLabel.Text = "Для корректной работы, выделите \n  'Переменные'";

			}
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				Constant constant = factory.CreateConstant(valueBox.Text);
				textBox.Text += " " + constant.getConstant();
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				Variable variable = factory.CreateVariable(nameBox.Text, valueBox.Text);
				textBox.Text += " " + variable.getVariable();
			}
			else if (comboBox1.SelectedIndex == 2)
			{
				string variables = "";
				foreach (var item in variablesList.SelectedItems)
				{
					variables += " " + item.ToString();
				}

				Links links = factory.CreateLinks(nameBox.Text, variables);
				textBox.Text += links.getLinks();
			}
		}


		interface AbstractFactory
		{
			public Constant CreateConstant(string value);
			public Variable CreateVariable(string name, string value);
			public Links CreateLinks(string name, string variables);

		}

		class ConcreteFactory : AbstractFactory
		{
			public Constant CreateConstant(string value)
			{
				return new Constant(value);
			}

			public Variable CreateVariable(string name, string value)
			{
				return new Variable(name, value);
			}

			public Links CreateLinks(string name, string variables)
			{
				return new Links(name, variables);
			}
		}
		// Proxy
		class LoggingConcreteFactory : AbstractFactory
		{
			private string logs;
			private AbstractFactory factory;

			const string CONSTANT = "constant";
			const string VARIABLE = "variable";
			const string LINKS = "links";

			public LoggingConcreteFactory()
			{
				factory = new ConcreteFactory();
			}

			public Constant CreateConstant(string value)
			{
				logs = logs + CONSTANT + " ";
				return factory.CreateConstant(value);
			}

			public Variable CreateVariable(string name, string value)
			{
				logs = logs + VARIABLE + " ";
				return factory.CreateVariable(name, value);
			}

			public Links CreateLinks(string name, string variables)
			{
				logs = logs + LINKS + " ";
				return factory.CreateLinks(name, variables);
			}

			public string getLogs()
			{
				return logs;
			}
		}
		public interface IMovable
		{
			void Move();
		}
		abstract class AbstractConstant
		{ public abstract string getConstant(); }

		abstract class AbstractVariable
		{ public abstract string getVariable(); }

		abstract class AbstractLinks
		{ public abstract string getLinks(); }


		class Constant : AbstractConstant
		{
			string value;

			public Constant(string value)
			{
				this.value = value;
			}

			override public string getConstant()
			{
				return "1[.] " + this.value + " 0[0]";
			}
		}

		class Variable : AbstractVariable
		{
			string name;
			string value;

			public Variable(string name, string value)
			{
				this.name = name;
				this.value = value;
			}

			override public string getVariable()
			{
				return "1[" + this.name + "] " + this.value + " 0[0]";
			}
		}

		class Links : AbstractLinks
		{
			string name;
			string variables;

			public Links(string name, string variables)
			{
				this.variables = variables;
				this.name = name;
			}

			override public string getLinks()
			{
				string result = $"[{name}] ";
				string[] vars = variables.Split(" ");
				foreach (string var in vars)
				{
					if (var != "0[0]" && !var.Contains("1[") && var != "")
					{
						result += var + "...";

					}
				}
				result += " 0[0]";
				return result;
			}
		}

		private void analyzeBtn_Click(object sender, EventArgs e)
		{
			// Реализация парсинга
			listBox1.Items.Clear();
			variablesList.Items.Clear();
			listBox3.Items.Clear();

			string text = textBox.Text;

			Regex regex = new Regex(@"1\[\.\](\s)*(\w)*(\s)*0\[0\]");
			MatchCollection match = regex.Matches(text);
			foreach (Match m in match)
			{
				listBox1.Items.Add(m.Value);
			}
			regex = new Regex(@"1\[(\w*)](\s)*(\w)*(\s)*0\[0\]");
			match = regex.Matches(text);
			foreach (Match m in match)
			{
				variablesList.Items.Add(m.Value);
			}
			regex = new Regex(@"\[(\w*)\](\s*)((\w*)\.\.\.)*(\s*)0\[0\]");
			match = regex.Matches(text);
			foreach (Match m in match)
			{
				listBox3.Items.Add(m.Value);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!(factory is LoggingConcreteFactory))
			{
				MessageBox.Show("Не поддерживает логирование действий", "Хронолигия действий");
				return;
			}
			LoggingConcreteFactory newFactory = (LoggingConcreteFactory)factory;
			MessageBox.Show(newFactory.getLogs(), "Хронолигия действий");
		}
	}
}