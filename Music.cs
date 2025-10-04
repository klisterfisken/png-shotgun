using System;
using System.Threading;

class Music
{
    public static void Play()
    {
        // Declare the first few notes of the song, "The good, the bad and the ugly".
        Note[] Western =
            {
        new Note(Tone.A, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.A, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.A, Duration.HALF),
        new Note(Tone.REST, Duration.HALF),
        new Note(Tone.F, Duration.HALF),
        new Note(Tone.G, Duration.HALF),
        new Note(Tone.D, Duration.HALF),
        };
        // Play the song
        Play(Western);
    }

    // Play the notes in a song.
    protected static void Play(Note[] tune)
    {
        foreach (Note n in tune)
        {
            if (n.NoteTone == Tone.REST)
                Thread.Sleep((int)n.NoteDuration);
            else
                Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
        }
    }

    // Define the frequencies of notes in an octave, as well as
    // silence (rest).
    protected enum Tone
    {
        REST = 0,
        A = 220,
        D = 294,
        F = 349,
        G = 392,
    }

    // Define the duration of a note in units of milliseconds.
    protected enum Duration
    {
        WHOLE = 1600,
        HALF = WHOLE / 2,
        QUARTER = HALF / 2,
        EIGHTH = QUARTER / 2,
        SIXTEENTH = EIGHTH / 2,
    }

    // Define a note as a frequency (tone) and the amount of
    // time (duration) the note plays.
    protected struct Note
    {
        Tone toneVal;
        Duration durVal;

        // Define a constructor to create a specific note.
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }

        // Define properties to return the note's tone and duration.
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
    }
}
/*
This example produces the following results:

This example plays the first few notes of "Western Had A Little Lamb"
through the console speaker.
*/