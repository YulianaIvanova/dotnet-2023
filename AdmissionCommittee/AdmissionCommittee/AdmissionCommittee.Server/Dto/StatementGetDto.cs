﻿namespace AdmissionCommittee.Server.Dto;
/// <summary>
/// Information about the entrant's statement
/// </summary>
public class StatementGetDto
{
    /// <summary>
    /// IdStatement - int value for storing the id statement
    /// </summary>
    public int IdStatement { get; set; }

    /// <summary>
    /// EntrantId - int value for storing the id entrant
    /// </summary>
    public int EntrantId { get; set; }
}