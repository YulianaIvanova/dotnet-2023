﻿namespace AdmissionCommittee.Server.Dto;
/// <summary>
/// Information about entrants
/// </summary>
public class EntrantGetDto
{
    /// <summary>
    /// IdEntrant - int type value for storing the id entrant
    /// </summary>
    public int IdEntrant { get; set; }

    /// <summary>
    /// FullName - string value for storing the entrant's full name
    /// </summary>
    public string FullName { get; set; } = string.Empty;

    /// <summary>
    /// DateBirth - DateTime value for storing the entrant's date of birth
    /// </summary>
    public DateTime DateBirth { get; set; }

    /// <summary>
    /// Country - string value for storing the entrant's country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// City - string value for storing the entrant's city
    /// </summary>
    public string? City { get; set; }
}