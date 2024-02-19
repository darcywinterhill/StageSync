# Stage Sync
Final project during System developer .NET studies @ Lexicon. Using ASP.NET Core MVC and Identity.
* NOTE that this project is NOT deployed and cannot be viewed live
* NOTE that the database setup for the scope is made using SQL Server to local database and will NOT be recreated if cloning and updating the project

## Project Description
* A web app where venues can book artists and artists can view their bookings.
* Login for both organizer/venue and artists and authentication to show the different pages.

### Scope
* Not possible to register more users. There is already one venue and three artists registered that can be used to login.
* Only possible for the venue to book/edit five dates. These bookings (without a booked artist) will already be in the database.
* To make it more visual there will already be six bookings (with booked artist) in the database that will be showing for the venue/artists.
* Because of the scope there are some things that are hard coded.

### Content
* Logged in venue has these pages: Overview, Bookings, Unbooked, Log Out
* Logged in artist has these pages: Start, Bookings, Log Out

## Things that can be altered
* It's possible to use the rest of the actions in the Artists-/BookingsController
* Switch hard coded parts to fit other users than the ones created for the scope
* Deploy project
