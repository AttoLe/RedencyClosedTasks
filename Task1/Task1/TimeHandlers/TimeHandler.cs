﻿using Task1.DataHandlers.Writers;

namespace Task1.TimeHandlers;

public class TimeHandler
{
    private Logger? _logger;
    
    public void ActivateTimer(Logger logger, int hour, int periodhour)
    {
        _logger = logger;
        var timer = new Timer(Callback);
        var endTime = DateTime.Today.AddHours(hour);
        
        try
        { 
            timer.Change(endTime - DateTime.Now, new TimeSpan(periodhour, 0, 0));
        }
        catch (Exception)
        {
           //error
        }
    }

    private void Callback(object? state) => _logger?.WriteLog();
}