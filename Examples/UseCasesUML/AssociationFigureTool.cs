//
// MonoHotDraw. Diagramming library
//
// Authors:
//	Manuel Cerón <ceronman@gmail.com>
//
// Copyright (C) 2006, 2007, 2008 MonoUML Team (http://www.monouml.org)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using Gdk;
using Gtk;
using MonoHotDraw;

namespace MonoHotDraw.Samples {

	public class AssociationFigureTool: CompositeFigureTool {
		public AssociationFigureTool (IDrawingEditor editor, IFigure fig, ITool dt): base (editor, fig, dt) {
		}


		public override void MouseDown (MouseEvent ev) {
			IDrawingView view = ev.View;
			LabelFigure label = ((AssociationFigure)Figure).FindLabel(ev.X, ev.Y);
			
			if (label != null && view.IsFigureSelected(Figure) ) {
				DelegateTool = new SimpleTextTool(Editor, label, DefaultTool);
			}
			else {
				DelegateTool = new PolyLineFigureTool(Editor, (IConnectionFigure)Figure, DefaultTool);
			}
				
			if (DelegateTool != null) {
				DelegateTool.MouseDown (ev);
			}

		}
		
		public override void Deactivate () {
			base.Deactivate ();
			((AssociationFigure)Figure).UpdateConnection();
		}
	}
}
