using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Document
    {
        //Reciever Object

        public void Open()
        {
            Console.WriteLine("Document Opened");
        }

        public void Save()
        {
            Console.WriteLine("Document Saved");
        }

        public void Close()
        {
            Console.WriteLine("Document Closed");
        }
    }

    //Command Interface
    public interface ICommand
    {
        void Execute();
    }

    //Concrete Commands
    public class OpenCommand : ICommand
    {
        private Document _document;

        public OpenCommand(Document document)
        {
            _document = document;
        }
        public void Execute()
        {
            _document.Open();
        }
    }

    public class SaveCommand : ICommand
    {
        private Document _document;

        public SaveCommand(Document document)
        {
            _document = document;
        }
        public void Execute()
        {
            _document.Save();
        }
    }

    public class CloseCommand : ICommand
    {
        private Document _document;

        public CloseCommand(Document document)
        {
            _document = document;
        }
        public void Execute()
        {
            _document.Close();
        }
    }


    //Invoker

    public class MenuOptions
    {
        private ICommand _openCommand;
        private ICommand _saveCommand;
        private ICommand _closeCommand;

        public MenuOptions(ICommand openCommand, ICommand saveCommand, ICommand closeCommand)
        {
            _openCommand = openCommand;
            _saveCommand = saveCommand;
            _closeCommand = closeCommand;
        }

        public void ClickOpen()
        {
            _openCommand.Execute();
        }

        public void ClickSave()
        {
            _saveCommand.Execute();
        }

        public void ClickClose()
        {
            _closeCommand.Execute();
        }
    }


}
