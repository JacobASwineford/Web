using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ScoreModel
    {
        public int Id { get; set; }
        public double Points { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }

        public static IEnumerable<ScoreModel> ToList(IEnumerable<Score> list) {
            List<ScoreModel> scores = new();
            foreach (Score score in list)
                scores.Add(FromEntity(score));
            return scores.AsEnumerable();
        }

        public static ScoreModel FromEntity(Score score) {
            ScoreModel model = new ScoreModel();
            model.Id = score.Id;
            model.Points = score.Points;
            model.StudentId = score.StudentId;
            model.AssignmentId = score.AssignmentId;
            return model;
        }

        public static Score ToEntity(ScoreModel model) {
            Score score = new Score();
            score.Id = model.Id;
            score.Points = model.Points;
            score.StudentId = model.StudentId;
            score.AssignmentId = model.AssignmentId;
            return score;
        }
    }
}
