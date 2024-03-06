namespace Tesla;

class Program
{
    static void Main(string[] args)
    {
        Instructions instr = new Instructions();
        Console.WriteLine("Seat belt instructions: " + instr.seatBelt() +
            " | Speed Limit Instruction:  " + instr.speedLimit());
    }
}

