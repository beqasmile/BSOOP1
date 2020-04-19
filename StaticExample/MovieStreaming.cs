using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPProject
{
    public class MovieStreaming

    {
        private int streamCount;
        public MovieStreaming()
        {
            streamCount = 0;
        }

        public void StreamMovieNow()
        {
            streamCount++;
        }

    }
}
