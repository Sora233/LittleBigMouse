﻿/*
  LittleBigMouse.Plugin.Vcp
  Copyright (c) 2017 Mathieu GRENET.  All right reserved.

  This file is part of LittleBigMouse.Plugin.Vcp.

    LittleBigMouse.Plugin.Vcp is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LittleBigMouse.Plugin.Vcp is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MouseControl.  If not, see <http://www.gnu.org/licenses/>.

	  mailto:mathieu@mgth.fr
	  http://www.mgth.fr
*/
using HLab.Mvvm;
using HLab.Mvvm.Icons;
using HLab.Plugin;
using LittleBigMouse.Control.Core;

namespace LittleBigMouse.Plugin.Vcp
{
    class ViewModeScreenVcp : ViewMode { }

    class VcpPlugin : PluginModule<VcpPlugin>
    {
        public override void Register()
        {
            MainService.D.MainViewModel.AddButton(IconService.D.GetIcon("IconVcp"),"Vcp control",
                () => MainService.D.MainViewModel.Presenter.ViewMode = typeof(ViewModeScreenVcp),
                () => MainService.D.MainViewModel.Presenter.ViewMode = typeof(ViewModeDefault));
        }
    }
}
