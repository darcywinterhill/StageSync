# Stage Sync
Final project during System developer .NET studies @ Lexicon. Using ASP.NET Core MVC and Identity.
* NOTE that this project is NOT deployed and cannot be viewed live
* For images of the project - please view this folder: StageSyncApp/wwwroot/images/printscreens
* NOTE that the database setup for the scope, with already existing bookings etc, is made using SQL Server to local database and will NOT be recreated if cloning and updating the project

## Project Description
* A responsive web app where venues can book artists and artists can view their bookings
* Login for both organizer/venue and artists and authentication to show the different pages

### Scope
* Not possible to register more users. There is already one venue and three artists registered that can be used to login
* Only possible for the venue to book/edit five dates. These bookings (without a booked artist) will already be in the database
* To make it more visual there will already be six bookings (with booked artist) in the database that will be showing for the venue/artists
* Because of the scope there are some things that are hard coded

### Content
* Logged in venue has these pages:
  - Overview
  - Bookings - divided by month
  - Unbooked - divided by month
  - Log Out
* If a venue has booked an artist to one of the five unbooked dates, a cancel/alter button is visible for that booking in the relevant views
* Logged in artist has these pages:
  - Start - with nr of bookings
  - Bookings - divided by month
  - Log Out

## Wiggle Room
* It's possible to change code and use the rest of the actions in the Artists-/BookingsController
* Switch hard coded parts to fit other users than the ones created for the scope
* Deploy project
