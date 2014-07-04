namespace GeometryAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FigureControlExtend : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                {
                    Vector3D center = Vector3D.Parse(splitFigString[1]);
                    float radius = float.Parse(splitFigString[2]);
                    currentFigure = new Circle(center, radius);
                    break;
                }
                case "cylinder":
                {
                    Vector3D topCenter = Vector3D.Parse(splitFigString[1]);
                    Vector3D bottomCenter = Vector3D.Parse(splitFigString[2]);
                    float radius = float.Parse(splitFigString[3]);
                    currentFigure = new Cilinder(topCenter, bottomCenter, radius);
                    break;
                }
                default :
                {
                    base.ExecuteFigureCreationCommand(splitFigString);
                    break;
                }
            }

            this.EndCommandExecuted = false;
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area" :
                    {
                        IAreaMeasurable currentAsAreaMeasurable = this.currentFigure as IAreaMeasurable;
                        if (currentAsAreaMeasurable != null)
                        {
                            Console.WriteLine("{0:F2}", currentAsAreaMeasurable.GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume" :
                    {
                        IVolumeMeasurable currentAsVolumeMeasurable = this.currentFigure as IVolumeMeasurable;
                        if (currentAsVolumeMeasurable != null)
                        {
                            Console.WriteLine("{0:F2}", currentAsVolumeMeasurable.GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal" :
                    {
                        IFlat currentAsFlat = this.currentFigure as IFlat;
                        if (currentAsFlat != null)
                        {
                            Vector3D normal = currentAsFlat.GetNormal();
                            Console.WriteLine("{0:F2}", normal);
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                default:
                    base.ExecuteFigureInstanceCommand(splitCommand);
                    break;
            }
        }
    }
}
