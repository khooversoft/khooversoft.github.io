# Blog Technology

I just wanted to share with you my challenges for getting a blog up and running.  I was looking for an easy way that
did not turn into a second job.  After doing some research on the web it appeared that the best route was to use a
hosting service that uses wordpress.

I tried this for a couple of months but it was a lot of work just to do simple things.  After awhile, I let my site go
to the recycling bin, not really happy with what I had produced.

After this initial attempt, I added a couple of new requirements and started to do more research.

1) Author all or most of the content in markdown.
2) Some type of hosting service that is backed by git and some type of automatic deployment process.  Docs need to be part of the CD/CI process.
3) Auto build API documentation from source code, use VS XML docs produced by VS builds.

I started focusing on static site builders and started using DocFx.  This is an open source system that meets the above
requirements and after some time to get started, it is pretty easy to use and customize.  But the best part is that I can
concentrate on writing and less on dealing with the site.

This site is built by DocFx.

