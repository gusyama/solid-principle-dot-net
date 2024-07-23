# Open/Closed Principle

## Bad Design
In the example code, we encounter a scenario there is a need to handle the generation of reports in various formats.

In this example, all the logic for generating reports is concentrated in ReportGenerationHelper.cs alone. 

This is problematic because when a new report format is introduced, we have to modify the class to check for the new report type and implement its generation logic there. 

This invalidates the tests previously guaranteed for the class.
