using Jewlery.Models;
using JewleryWPF_Lab.Base;
using System.Windows;
using JewleryWPF_Lab.ViewModels;
using AutoMapper;
using System;

namespace JewleryWPF_Lab
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        private DataModel _model;
        private DataViewModel _viewModel;
        public App()
        {
            new Mapping().Create();
            _model = DataModel.Load();
            _viewModel = Mapper.Map<DataModel, DataViewModel>(_model);

            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _model = Mapper.Map<DataViewModel, DataModel>(_viewModel);
                _model.Save();
            }
            catch(Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
