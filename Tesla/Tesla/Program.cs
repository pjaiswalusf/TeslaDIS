namespace Tesla;

class Program
{
    static void Main(string[] args)
    {

        ModelType Type = new ModelType();
        Console.WriteLine("The Model Name and year are: " + Type.getModel());

        Engine engine1 = new Engine();
        Console.WriteLine("Tesla Engine and Horsepower details are: " + engine1.EngineDetails());

        Instructions instr = new Instructions();
        Console.WriteLine("Seat belt instructions: " + instr.seatBelt() +
            " | Speed Limit Instruction:  " + instr.speedLimit());

        Model model = new Model();
        Console.WriteLine(model.getModel());

        Wheels wheel1 = new Wheels();
        Console.WriteLine("The wheel size is: " + wheel1.getWheelSize());
    }
}

