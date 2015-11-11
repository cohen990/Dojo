using System;
using System.Collections.Generic;
using Atlassian.Jira;

namespace Dojo
{
	class Program
	{
		static void Main(string[] args)
		{
		    Jira jira = new Jira("https://jira.euromoneydigital.com", "appdash", "Dinosaur1965");
		    string jql =
		        "(type = \"Scheduled Release\" OR type = \"Emergency Release\") AND (\"Release Date Select\" >= 2015-11-09 AND \"Release Date Select\" <= 2015-11-15)";
		    int maxIssues = 500;

		    IEnumerable<Issue> result = jira.GetIssuesFromJql(jql, maxIssues);

		    foreach (var issue in result)
		    {
		        Console.WriteLine(issue.JiraIdentifier);
		    }
		}
	}
}
