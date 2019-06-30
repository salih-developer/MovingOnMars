using MovingOnMars.Bussiness.Command;
using MovingOnMars.Bussiness.Direction;
using MovingOnMars.Bussiness.Direction.Base;
using MovingOnMars.Bussiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovingOnMars.Bussiness
{
    using System.Security.Cryptography.X509Certificates;

    public class VehicleManager: IVehicleManager
    {
        private string _Commands;

        private GridArea _GridArea { get; set; }
        private IDirection _Direction { get; set; }
        private ICoordinate _Coordinate { get; set; }
        private VehicleManager(string area, string position, string commands)
        {
            this._Commands = commands;
            position = position.Replace(" ", "");
            area = area.Replace(" ", "");

            this._GridArea = new GridArea(Convert.ToInt32(area[0].ToString()), Convert.ToInt32(area[1].ToString()));

            var directions = new List<IDirection>(new IDirection[]
                                                      {
                                                          new NorthDirection(),
                                                          new WestDirection(),
                                                          new EastDirection(),
                                                          new SouthDirection()
                                                      });

            var directionString = position[2];
            _Direction = directions.FirstOrDefault(x => x.Direction == directionString);

            _Coordinate = new Coordinate(Convert.ToInt32(position[0].ToString()), Convert.ToInt32(position[1].ToString()));

        }

        public string Operation()
        {
            var areaResult = new AreaResult(_Direction, _Coordinate);
            foreach (var command in _Commands)
            {
                Command.Base.Command cmd;
                switch (command)
                {
                    case 'L':
                        cmd = new LeftCommand(areaResult.Direction, areaResult.Coordinate);
                        break;
                    case 'R':
                        cmd = new RightCommand(areaResult.Direction, areaResult.Coordinate);
                        break;
                    case 'M':
                        cmd = new MoveCommand(areaResult.Direction, areaResult.Coordinate);
                        break;
                    default: throw new ArgumentException($"Invalid command parameter {command}");
                }
                areaResult = cmd.Execute();
                if (!_GridArea.ValidPosition(areaResult.Coordinate))
                    throw new ArgumentOutOfRangeException($"Coordinate unknow {areaResult.Coordinate}");
            }
            return areaResult.ToString();
        }

        public static VehicleManager Create(string area, string position, string commands)
        {
            return new VehicleManager( area, position, commands);
        }
    }
}
