
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;


namespace ReportExample
{
    class ViewModel
    {
        private MainWindow _window;  
	        private LocalReport _Report;  
	        private ReportViewer _reportviewer;  
	        public ViewModel(MainWindow window)  
	        {  
	            _window = window;  
	            this. _reportviewer = window. _reportviewer;  
	            Initialize ();  
	  
	        }  
	  
	private IEnumerable<Person> people = new List<Person>()
    {       new Person { Name = "Gloria", id = 46, Age =12} ,  
	        new Person {Name = "John", id = 1, Age =23},  
	        new Person {Name = "Francis My Staff", id = 2, Age =12},  
	        new Person {Name = "Ndu", id = 3, Age =32},  
	        new Person {Name = "Murphy", id = 4, Age =22},  
	        new Person {Name = "Mr Charles our boss", id = 5, Age =52}
    };    
   
	      private void Initialize ()  
	        {  
	             _reportviewer.LocalReport.DataSources.Clear();  
	             var rpds_model = new ReportDataSource () { Name = "Person_DS",Value = people };  
	            _reportviewer.LocalReport.DataSources.Add(rpds_model);  
	            _reportviewer.LocalReport.EnableExternalImages = true;  
	             string _path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory. GetCurrentDirectory())));  
	             string ContentStart = _path + @"\ReportExample\Report1.rdlc";  
	            _reportviewer.LocalReport.ReportPath = ContentStart;  
	            _reportviewer.SetDisplayMode(DisplayMode.PrintLayout);  
	            _reportviewer.Refresh();  
	            _reportviewer.RefreshReport();  
	        }  
	   }  

    
}
