using System;
using Microsoft.WindowsAzure.MobileServices;

namespace HelloGlobalAzure
{
	public class Service
	{
public static MobileServiceClient MobileService =
new MobileServiceClient(
"https://gabtvmxamarin.azurewebsites.net"
);
	}
}
