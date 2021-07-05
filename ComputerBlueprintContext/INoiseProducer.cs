namespace ComputerBlueprintContext
{
    public interface INoiseProducer
    {
        int LowNoiseInDecibles { get;  }
        int HighNoiseInDecibles { get;  }
    }
}