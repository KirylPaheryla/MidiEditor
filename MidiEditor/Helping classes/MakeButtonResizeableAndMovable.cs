using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiEditor
{
    internal class MakeButtonResizeableAndMovable
    {
        private static bool isMoving;
        private static bool isResizing;
        private static Point cursorStartPoint;
        private static bool isMoveInternal;
        private static Size currentSize;
        private static bool isMouseOnLeftEdge;
        private static bool isMouseOnRightEdge;
        private static ActionType CurrentActionType;

        internal enum ActionType
        {
            Move,
            Resize,
            MoveAndResize
        }

        internal static void Init(Button button)
        {
            isMoving = false;
            isResizing = false;
            isMoveInternal = false;
            cursorStartPoint = Point.Empty;
            isMouseOnLeftEdge = false;
            isMouseOnRightEdge = false;
            CurrentActionType = ActionType.MoveAndResize;
            button.MouseDown += (sender, e) => StartAction(button, e);
            button.MouseUp += (sender, e) => StopAction(button);
            button.MouseMove += (sender, e) => MoveButton(button, e);
        }

        private static void UpdateMouseEdgeProperties(Button button, Point mouseLocationInControl)
        {
            if (CurrentActionType == ActionType.Move)
            {
                return;
            }
            isMouseOnLeftEdge = Math.Abs(mouseLocationInControl.X) <= 2;
            isMouseOnRightEdge = Math.Abs(mouseLocationInControl.X - button.Width) <= 2;
        }

        private static void UpdateMouseCursor(Button button)
        {
            if (CurrentActionType == ActionType.Move)
            {
                return;
            }
            if (isMouseOnLeftEdge)
            {
                if (AppSettings.CurrentCursorStatus == AppSettings.CursorStatus.Erase)
                    button.Cursor = Cursors.Cross; //control.Cursor = new Cursor(Properties.Resources.cursorEraser.Handle);
                else
                    button.Cursor = Cursors.SizeWE;
            }
            else if (isMouseOnRightEdge)
            {
                if (AppSettings.CurrentCursorStatus == AppSettings.CursorStatus.Erase)
                    button.Cursor = Cursors.Cross; //control.Cursor = new Cursor(Properties.Resources.cursorEraser.Handle);
                else
                    button.Cursor = Cursors.SizeWE;
            }
            else
            {
                if (AppSettings.CurrentCursorStatus == AppSettings.CursorStatus.Erase)
                    button.Cursor = Cursors.Cross; //control.Cursor = new Cursor(Properties.Resources.cursorEraser.Handle);
                else
                    button.Cursor = Cursors.Default;
            }
        }

        private static void StartAction(Button button, MouseEventArgs e)
        {
            if (isMoving || isResizing)
            {
                return;
            }
            if (CurrentActionType != ActionType.Move && (isMouseOnLeftEdge || isMouseOnRightEdge))
            {
                isResizing = true;
                currentSize = button.Size;
            }
            else if (CurrentActionType != ActionType.Resize)
            {
                isMoving = true;
                if (AppSettings.CurrentCursorStatus == AppSettings.CursorStatus.Erase)
                    //control.Cursor = new Cursor(Properties.Resources.cursorEraser.Handle);
                    button.Cursor = Cursors.Cross;
                else
                    button.Cursor = Cursors.SizeAll;
            }
            cursorStartPoint = new Point(e.X, e.Y);
            button.Capture = true;
        }

        private static void MoveButton(Button button, MouseEventArgs e)
        {
            if (!isResizing && !isMoving)
            {
                UpdateMouseEdgeProperties(button, new Point(e.X, e.Y));
                UpdateMouseCursor(button);
            }
            if (isResizing)
            {
                if (isMouseOnLeftEdge)
                {
                    button.Width -= (e.X - cursorStartPoint.X);
                    button.Left += (e.X - cursorStartPoint.X);
                }
                else if (isMouseOnRightEdge)
                {
                    button.Width = (e.X - cursorStartPoint.X) + currentSize.Width;
                }
                else
                {
                    StopAction(button);
                }
            }
            else if (isMoving)
            {
                isMoveInternal = !isMoveInternal;
                if (!isMoveInternal)
                {
                    int x = (e.X - cursorStartPoint.X) + button.Left;
                    int y = (e.Y - cursorStartPoint.Y) + button.Top;

                    if (y % AppSettings.YScale == 0)
                    {
                        button.Location = new Point(x, y);
                    }
                    else
                    {
                        if (y > AppSettings.YScale)
                        {
                            for (int i = 1; i < AppSettings.YScale; i++)
                            {
                                if ((y - i) % AppSettings.YScale == 0)
                                    button.Location = new Point(x, y - i);
                            }
                        }
                        else if (y < AppSettings.YScale)
                        {
                            for (int i = 1; i < AppSettings.YScale; i++)
                            {
                                if ((y + i) % AppSettings.YScale == 0)
                                    button.Location = new Point(x, y + i);
                            }
                        }
                        else
                        {
                            button.Location = new Point(x, y);
                        }
                    }
                    //Form1.events.Find(ev => ev.Button == button).Note = 127 - (button.Location.Y / AppSettings.YScale);
                    //Form1.events.Find(ev => ev.Button == button).Time = button.Location.X;
                }
            }
        }

        private static void StopAction(Button button)
        {
            isResizing = false;
            isMoving = false;
            button.Capture = false;
            UpdateMouseCursor(button);
        }
    }
}
