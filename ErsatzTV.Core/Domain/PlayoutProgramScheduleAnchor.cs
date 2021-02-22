﻿namespace ErsatzTV.Core.Domain
{
    public class PlayoutProgramScheduleAnchor
    {
        public int Id { get; set; }
        public int PlayoutId { get; set; }
        public Playout Playout { get; set; }
        public int ProgramScheduleId { get; set; }
        public ProgramSchedule ProgramSchedule { get; set; }
        public ProgramScheduleItemCollectionType CollectionType { get; set; }
        public int CollectionId { get; set; }
        public MediaCollectionEnumeratorState EnumeratorState { get; set; }
    }
}
