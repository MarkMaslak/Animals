using System;

namespace AnimalsRepo
{
    /// <summary>
    /// Represent the health of any animal.
    /// </summary>
    public interface Health
    {
        bool Healthy { get; }
        string infection { get; }
    }
}
}
