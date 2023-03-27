﻿namespace AdmissionCommittee.Server.Dto;
/// <summary>
/// Information about the result of the entrant's exam
/// </summary>
public class ResultPostDto
{
    /// <summary>
    /// NameSubject - string value for storing the name of the subject(exam)
    /// </summary>
    public string NameSubject { get; set; }

    /// <summary>
    /// Mark - int value for storing the exam score
    /// </summary>
    public int Mark { get; set; }
}