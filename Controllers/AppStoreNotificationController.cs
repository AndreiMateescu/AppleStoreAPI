using Microsoft.AspNetCore.Mvc;
using Subscriptions.Interfaces;
using Subscriptions.Models;

namespace Subscriptions.Controllers;


//------------------------------------------------------------------------------
// AppStoreNotificationController
//------------------------------------------------------------------------------

[ApiController]
[Route("notification")]
public class AppStoreNotificationController : Controller
{
    private readonly INotificationProcessor _notificationProcessor;
    private readonly IAppleStoreTokenService _appleStoreTokenService;
    private readonly INotificationRepository _notificationRepository;


    //------------------------------------------------------------------------------
    // AppStoreNotificationController
    //------------------------------------------------------------------------------

    public AppStoreNotificationController(INotificationProcessor notificationProcessor, IAppleStoreTokenService appleStoreTokenService, INotificationRepository notificationRepository)
    {
        _notificationProcessor = notificationProcessor;
        _appleStoreTokenService = appleStoreTokenService;
        _notificationRepository = notificationRepository;
    }

    //------------------------------------------------------------------------------
    // Get
    //------------------------------------------------------------------------------

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok(await _notificationRepository.GetNotifications());
    }


    //------------------------------------------------------------------------------
    // Notification
    //------------------------------------------------------------------------------

    [HttpPost("appstore")]
    public ActionResult Notification([FromBody] AppleNotification appleNotification)
    {
        try
        {
            _notificationProcessor.Process(appleNotification);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }


    //------------------------------------------------------------------------------
    // GetAppleStoreToken
    //------------------------------------------------------------------------------

    [HttpGet("token")]
    public ActionResult GetAppleStoreToken()
    {
        try
        {
            var token = _appleStoreTokenService.GetToken();
            return Ok(token);
        }
        catch
        {
            return StatusCode(500);
        }
    }


    //------------------------------------------------------------------------------
    // HealthCheck
    //------------------------------------------------------------------------------

    [HttpGet("healthcheck")]
    public ActionResult HealthCheck()
    {
        return Ok("Application is running");
    }
}