using MyTools;
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

        public static void CreateProjectile(StringBuilder sb, char[][] charMap, Projectile projectile)
        {
            Timer timer = new Timer(_ =>
            {
                projectile.ProjectileDrawMap(sb, charMap);
                projectile.ProjectileAttacksOne();
            }, null, 0, 300);

        }

        public void ProjectileAttacksOne()
        {
            UpDown++;
            LeftRight++;
        }

        public void ProjectileDrawMap(StringBuilder sb, char[][] charMap)
        {
            if (Up)
            {
                DrawUpOrDown(sb, charMap);
                ClearUp(sb, charMap);
            }
            else if (Down)
            {
                DrawUpOrDown(sb, charMap);
                ClearDown(sb, charMap);
            }
            else if (Left)
            {
                ClearandDrawLeft(sb, charMap);
            }
            else if (Right)
            {
                ClearAndDrawRight(sb, charMap);
            }
        }

        public void DrawUpOrDown(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, ProjectileCharacter);
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public void ClearUp(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown + 1]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public void ClearDown(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown - 1]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public void ClearandDrawLeft(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, ProjectileCharacter).Remove(LeftRight + 1, 1).Insert(LeftRight + 1, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public void ClearAndDrawRight(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, ProjectileCharacter).Remove(LeftRight - 1, 1).Insert(LeftRight - 1, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }
    }
}
