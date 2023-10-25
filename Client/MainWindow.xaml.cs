using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private string _name;
		public string Name
		{
			get => _name;
			set =>_name = value;
		}

		private string _track;
		public string Track
		{
			get => _track;
			set => _track = value;
		}

		private string _state;
		public string State
		{
			get => _state;
			set => _state = value;
		}

		private DateTime _startTime;
		public DateTime StartTime
		{
			get => _startTime;
			set => _startTime = value;
		}

		private Duration _duration;
		public Duration Duration
		{
			get => _duration;
			set => _duration = value;
		}

		private TimeSpan _timeRemaining;
		public TimeSpan TimeRemaining
		{
			get => _timeRemaining;
			set => _timeRemaining = value;
		}

		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
