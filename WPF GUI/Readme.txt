Frameworks Used
===============
Architechtural Pattern:
MVVM
http://msdn.microsoft.com/en-us/magazine/dd419663.aspx

Framework Used:
MVVM Light
http://mvvmlight.codeplex.com/documentation

Zune Like UI: MahApps
http://mahapps.com/MahApps.Metro/

Color Picker: Extended WPF Toolkit
http://wpftoolkit.codeplex.com/

Structure of Program:
MainWindow.Xaml is the Startup Window.
	Draws information via DataBinding from MainViewModel.cs
		MainViewModel is populated with data from ViewModelLocator, which uses SimpleIOC to inject data via DataService

Loading Data
============
DataService, which is an implementation of IDataService loads the data into an DataItem, which is then injected into MainViewModel.

DesignDataService is an implementation of IDataService which loads fake data for use in Design Time.

//asdfasd

			
