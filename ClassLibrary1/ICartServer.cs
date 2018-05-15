using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICartSaver
    {
        int SaveCartItem(int cartId, int productId);
    }
}
