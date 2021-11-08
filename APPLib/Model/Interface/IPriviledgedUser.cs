using System;
using System.Collections.Generic;
using System.Text;

namespace APPLib.Model.Interface
{
    interface IPriviledgedUser
    {
        bool OpenDoor(string IdCard);
    }
}
