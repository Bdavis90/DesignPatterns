using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommnad();

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\n--------------Remote Control--------------");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append($"[slot {i}] {onCommands[i].GetType().Name} \t {offCommands[i].GetType().Name} \n");
            }

            return sb.ToString();
        }
    }
}
