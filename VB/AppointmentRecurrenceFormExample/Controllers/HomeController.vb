﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.XtraScheduler
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraScheduler.Native

Namespace AppointmentRecurrenceFormExample.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Dim recurrenceInfo As New RecurrenceInfo() With {.Start = Date.Today, .End = Date.Today.Add(TimeSpan.FromDays(1)), .Type = RecurrenceType.Weekly, .AllDay = True}
            Return View("Index", recurrenceInfo)
        End Function
        Public Function RecurrenceFormInfo() As ActionResult
            Dim pattern As Appointment = DevExpress.XtraScheduler.Compatibility.StaticAppointmentFactory.CreateAppointment(AppointmentType.Pattern)
            pattern.Start = New Date(2012, 10, 20, 3, 0, 0)
            pattern.End = New Date(2012, 10, 20, 4, 0, 0)
            Dim recurrenceInfo As RecurrenceInfo = AppointmentRecurrenceFormExtension.GetValue("RecurrenceControl", pattern)
            Return View("RecurrenceFormInfo", DirectCast(recurrenceInfo.ToXml(), Object))
        End Function
    End Class
End Namespace
