using Service.BindingModel;
using Service.Interfaces;
using System;
using System.Windows;
using Microsoft.Reporting.WinForms;
using Unity;
using Unity.Attributes;
using Microsoft.Win32;

namespace CustomerInterface
{
    /// <summary>
    /// Логика взаимодействия для FormCustomerEntrys.xaml
    /// </summary>
    public partial class FormCustomerEntrys : Window
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IReportService service;

        public FormCustomerEntrys(IReportService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.SelectedDate >= dateTimePickerTo.SelectedDate)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                reportViewer.LocalReport.ReportEmbeddedResource = "CustomerInterface.ReportCustomerEntry.rdlc";
                ReportParameter parameter = new ReportParameter("ReportParameterPeriod",
                                            "c " + dateTimePickerFrom.SelectedDate.ToString() +
                                            " по " + dateTimePickerTo.SelectedDate.ToString());
                reportViewer.LocalReport.SetParameters(parameter);


                var dataSource = service.GetCustomerEntrys(new ReportBindingModel
                {
                    DateFrom = dateTimePickerFrom.SelectedDate,
                    DateTo = dateTimePickerTo.SelectedDate
                });
                ReportDataSource source = new ReportDataSource("DataSetEntrys", dataSource);
                reportViewer.LocalReport.DataSources.Add(source);




                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void buttonMail_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
