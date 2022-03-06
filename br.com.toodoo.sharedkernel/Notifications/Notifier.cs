﻿using br.com.toodoo.sharedkernel.Interfaces;

namespace br.com.toodoo.sharedkernel.Notifications;

public class Notifier : INotifier
{
    private List<Notification> _notifications;
    public Notifier()
    {
        _notifications = new List<Notification>();
    }
    public List<Notification> GetNotifications()
    {
        return _notifications;
    }

    public void Handle(Notification notification)
    {
        _notifications.Add(notification);
    }

    public bool HasNotification()
    {
        return _notifications.Any();
    }
}
