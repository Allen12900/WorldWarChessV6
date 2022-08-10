using System;
using System.Collections.Generic;
using System.Text;

namespace WorldWarChessV6
{
    //This was made by Naod
    public class GameState
    {
        public class Piece
        {
            public string pieceName { get; set; }
            public string pieceColour { get; set; }
            public int pieceHealth { get; set; }
            public int pieceMoveDistance { get; set; }
            public int pieceAttackDistance { get; set; }

            public void setName(string name)
            {
                pieceName = name;
            }
            public string getName()
            {
                return pieceName;
            }

            public void setColour(string colour)
            {
                pieceColour = colour;
            }
            public string getColour()
            {
                return pieceColour;
            }

            public void setHealth(int health)
            {
                pieceHealth = health;
            }
            public int getHealth()
            {
                return pieceHealth;
            }

            public void setMoveDistance(int moveDistance)
            {
                pieceMoveDistance = moveDistance;
            }
            public int getMoveDistance()
            {
                return pieceMoveDistance;
            }

            public void setAttackDistance(int attackDistance)
            {
                pieceAttackDistance = attackDistance;
            }
            public int getAttackDistance()
            {
                return pieceAttackDistance;
            }
        }

        public class Jester : Piece
        {
            public int scarecrowDistance { get; set; }
            public void setScarecrowDistance(int scarecrowDist)
            {
                scarecrowDistance = scarecrowDist;
            }
            public int getScarecrowDistance()
            {
                return scarecrowDistance;
            }
        }
        public class GuyWhoDosentGiveAShit : Piece
        {

        }
        public class LilUzi : Piece
        {

        }
        public class WholesomeGuy : Piece
        {
            public int enhanceDistance { get; set; }
            public void setEnhanceDistance(int enhanceDist)
            {
                enhanceDistance = enhanceDist;
            }
            public int getEnhanceDistance()
            {
                return enhanceDistance;
            }

        }
        public class Bazooka : Piece
        {

        }
        public class Artillery : Piece
        {

        }
        public class Guard : Piece
        {

        }
        public class Shotgun : Piece
        {

        }
        public class Sniper : Piece
        {

        }
        public class Scout : Piece
        {

        }
        public class MachineGunner : Piece
        {

        }
        public class Infantry : Piece
        {

        }

        public void createPieces()
        {
            createWhitePieces();
            createBlackPieces();
        }
        public void createWhitePieces()
        {
            Jester jester = new Jester();
            jester.setName("Jester");
            jester.setColour("White");
            jester.setHealth(2);
            jester.setMoveDistance(3);
            jester.setAttackDistance(0);
            jester.setScarecrowDistance(1);

            GuyWhoDosentGiveAShit guyWhoDosentGiveAShit = new GuyWhoDosentGiveAShit();
            guyWhoDosentGiveAShit.setName("GuyWhoDosntGiveAShit");
            guyWhoDosentGiveAShit.setColour("White");
            guyWhoDosentGiveAShit.setHealth(1); // Health was not given
            guyWhoDosentGiveAShit.setMoveDistance(2);
            guyWhoDosentGiveAShit.setAttackDistance(1);

            LilUzi lilUzi = new LilUzi();
            lilUzi.setName("LilUzi");
            lilUzi.setColour("White");
            lilUzi.setHealth(1); // Health was not given
            lilUzi.setMoveDistance(3);
            lilUzi.setAttackDistance(1);

            WholesomeGuy wholesomeGuy = new WholesomeGuy();
            wholesomeGuy.setName("WholesomeGuy");
            wholesomeGuy.setColour("White");
            wholesomeGuy.setHealth(1); // Health was not given
            wholesomeGuy.setMoveDistance(2);
            wholesomeGuy.setAttackDistance(0);
            wholesomeGuy.setEnhanceDistance(1);

            Bazooka bazooka = new Bazooka();
            bazooka.setName("Bazooka");
            bazooka.setColour("White");
            bazooka.setHealth(1); // Health was not given
            bazooka.setMoveDistance(1);
            bazooka.setAttackDistance(3);

            Artillery artillery = new Artillery();
            artillery.setName("Artillery");
            artillery.setColour("White");
            artillery.setHealth(3);
            artillery.setMoveDistance(0);
            artillery.setAttackDistance(2);

            Guard guard = new Guard();
            guard.setName("Guard");
            guard.setColour("White");
            guard.setHealth(1); // Health was not given
            guard.setMoveDistance(2);
            guard.setAttackDistance(2);

            Shotgun shotgun = new Shotgun();
            shotgun.setName("Shotgun");
            shotgun.setColour("White");
            shotgun.setHealth(1); // Health was not given
            shotgun.setMoveDistance(2);
            shotgun.setAttackDistance(2);

            Sniper sniper = new Sniper();
            sniper.setName("Sniper");
            sniper.setColour("White");
            sniper.setHealth(1); // Health was not given
            sniper.setMoveDistance(1);
            sniper.setAttackDistance(4);

            Scout scout = new Scout();
            scout.setName("Scout");
            scout.setColour("White");
            scout.setHealth(1); // Health was not given
            scout.setMoveDistance(1);
            scout.setAttackDistance(2);

            MachineGunner machineGunner = new MachineGunner();
            machineGunner.setName("MachineGunner");
            machineGunner.setColour("White");
            machineGunner.setHealth(1); // Health was not given
            machineGunner.setMoveDistance(1);
            machineGunner.setAttackDistance(3);

            Infantry infantry = new Infantry();
            infantry.setName("Infantry");
            infantry.setColour("White");
            infantry.setHealth(1); // Health was not given
            infantry.setMoveDistance(2);
            infantry.setAttackDistance(2);
        }
        public void createBlackPieces()
        {
            Jester jester = new Jester();
            jester.setName("Jester");
            jester.setColour("Black");
            jester.setHealth(2);
            jester.setMoveDistance(3);
            jester.setAttackDistance(0);
            jester.setScarecrowDistance(1);

            GuyWhoDosentGiveAShit guyWhoDosentGiveAShit = new GuyWhoDosentGiveAShit();
            guyWhoDosentGiveAShit.setName("GuyWhoDosntGiveAShit");
            guyWhoDosentGiveAShit.setColour("Black");
            guyWhoDosentGiveAShit.setHealth(1); // Health was not given
            guyWhoDosentGiveAShit.setMoveDistance(2);
            guyWhoDosentGiveAShit.setAttackDistance(1);

            LilUzi lilUzi = new LilUzi();
            lilUzi.setName("LilUzi");
            lilUzi.setColour("Black");
            lilUzi.setHealth(1); // Health was not given
            lilUzi.setMoveDistance(3);
            lilUzi.setAttackDistance(1);

            WholesomeGuy wholesomeGuy = new WholesomeGuy();
            wholesomeGuy.setName("WholesomeGuy");
            wholesomeGuy.setColour("Black");
            wholesomeGuy.setHealth(1); // Health was not given
            wholesomeGuy.setMoveDistance(2);
            wholesomeGuy.setAttackDistance(0);
            wholesomeGuy.setEnhanceDistance(1);

            Bazooka bazooka = new Bazooka();
            bazooka.setName("Bazooka");
            bazooka.setColour("Black");
            bazooka.setHealth(1); // Health was not given
            bazooka.setMoveDistance(1);
            bazooka.setAttackDistance(3);

            Artillery artillery = new Artillery();
            artillery.setName("Artillery");
            artillery.setColour("Black");
            artillery.setHealth(3);
            artillery.setMoveDistance(0);
            artillery.setAttackDistance(2);

            Guard guard = new Guard();
            guard.setName("Guard");
            guard.setColour("Black");
            guard.setHealth(1); // Health was not given
            guard.setMoveDistance(2);
            guard.setAttackDistance(2);

            Shotgun shotgun = new Shotgun();
            shotgun.setName("Shotgun");
            shotgun.setColour("Black");
            shotgun.setHealth(1); // Health was not given
            shotgun.setMoveDistance(2);
            shotgun.setAttackDistance(2);

            Sniper sniper = new Sniper();
            sniper.setName("Sniper");
            sniper.setColour("Black");
            sniper.setHealth(1); // Health was not given
            sniper.setMoveDistance(1);
            sniper.setAttackDistance(4);

            Scout scout = new Scout();
            scout.setName("Scout");
            scout.setColour("Black");
            scout.setHealth(1); // Health was not given
            scout.setMoveDistance(1);
            scout.setAttackDistance(2);

            MachineGunner machineGunner = new MachineGunner();
            machineGunner.setName("MachineGunner");
            machineGunner.setColour("Black");
            machineGunner.setHealth(1); // Health was not given
            machineGunner.setMoveDistance(1);
            machineGunner.setAttackDistance(3);

            Infantry infantry = new Infantry();
            infantry.setName("Infantry");
            infantry.setColour("Black");
            infantry.setHealth(1); // Health was not given
            infantry.setMoveDistance(2);
            infantry.setAttackDistance(2);
        }
    }
}