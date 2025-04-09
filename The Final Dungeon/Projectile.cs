using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllProjectiles
{
    public class Projectile
    {
        public string ProjectileCharacter { get; set; }
        public int UpDown { get; set; }
        public int LeftRight { get; set; }
        public bool Up {  get; set; }
        public bool Down { get; set; }
        public bool Left { get; set; }
        public bool Right { get; set; }

        public Projectile(string projectileCharacter, int upDown = 1, int leftRight = 1)
        {
            ProjectileCharacter = projectileCharacter;
            UpDown = upDown;
            LeftRight = leftRight;
            Up = false;
            Down = false;
            Left = false;
            Right = false;
        }

        public void CreateProjectile()
        {
            Projectile projectile1 = new Projectile("*");
            Timer timer = new Timer(_ =>
            {
                
            }, null, 0, 300);

        }
    }
}
