using System.Collections;

namespace LUDU_Game_6a
{
    internal class WaitforSeconds : IEnumerator
    {
        private double v;

        public WaitforSeconds(double v)
        {
            this.v = v;
        }
    }
}