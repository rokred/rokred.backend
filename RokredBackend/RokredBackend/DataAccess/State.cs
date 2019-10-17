﻿using System;
using System.Collections.Generic;
using RokredBackend.Models;

namespace RokredBackend.DataAccess
{
    public static class State
    {
        private static Guid FirstGuid = Guid.NewGuid();
        private static Guid SecondGuid = Guid.NewGuid();
        private static Guid SubjectOneGuid = Guid.NewGuid();
        private static Guid SubjectTwoGuid = Guid.NewGuid();

        public static List<Opinion> CurrentOpinions = new List<Opinion>
        {
            new Opinion { Guid = FirstGuid.ToString(), MyOpinion = "Avengers Endgame is one of the best films ever created", SubjectKey = SubjectOneGuid.ToString() },
            new Opinion { Guid = Guid.NewGuid().ToString(), OpinionThreadKey = FirstGuid.ToString(), MyOpinion = "I disagree, I think Endgame isn't any good", Position = 1, SubjectKey = SubjectOneGuid.ToString() },
            new Opinion { Guid = Guid.NewGuid().ToString(), OpinionThreadKey = FirstGuid.ToString(), MyOpinion = "I think it's ok, not bad, not great", Position = 2, SubjectKey = SubjectOneGuid.ToString() },
            new Opinion { Guid = SecondGuid.ToString(), MyOpinion = "Mondays are the worst day of the week", SubjectKey = SubjectTwoGuid.ToString() },
            new Opinion { Guid = Guid.NewGuid().ToString(), OpinionThreadKey = SecondGuid.ToString(), MyOpinion = "Nah I think Wednesday are the worst", Position = 1, SubjectKey = SubjectTwoGuid.ToString() },
        };

        public static List<Subject> CurrentSubjects = new List<Subject>
        {
            new Subject { Guid = SubjectOneGuid.ToString(), MySubject = "Comic Book Films" },
            new Subject { Guid = SubjectTwoGuid.ToString(), MySubject = "Days of the Week" },
        };
    }
}
