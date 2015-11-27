Feature: sitemap xml test

Scenario Outline: sitemap that contains XMLs should display correctly
	Given I'm on the "<site_url>" page of "<site_root>"
	Then The root element in xml of "<site_root>" 's attribute should be correct in XML that contains XMLs
	And The XML structure of "<site_root>" should be right in XML that contains XMLs
	Then On "<id>" the XML should contains:
		| URL                                                       |
		| /sitemap_details.xml                      |
		| /sitemap_results_vendita_residenziale.xml |
		| /sitemap_results_vendita_commerciale.xml  |
		| /sitemap_results_vendita_vacanze.xml      |
		| /sitemap_results_affitti_residenziale.xml |
		| /sitemap_results_affitti_commerciale.xml  |
		| /sitemap_results_affitti_vacanze.xml      |
		| /sitemap_agency_folders.xml               |
		| /sitemap_find_agents_urls.xml             |
		| /sitemap_legacy_urls.xml                  |
	Examples: 
	| id                                 | site_root   | site_url                                                             |
	| index-main                         | www.casa.it | sitemap.aspx                                                         |

	



