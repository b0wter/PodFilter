﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace PodfilterTests.Data
{
    static class SamplePodcasts
    {
        public const string NewsPodcastForStringFilter = "<?xml version=\"1.0\" encoding=\"utf-8\"?> <?xml-stylesheet type=\"text/xsl\" media=\"screen\" href=\"http://www.deutschlandfunk.de/themes/dradio/podcast/podcast.xsl\"?><rss xmlns:itunes=\"http://www.itunes.com/dtds/podcast-1.0.dtd\" xmlns:atom=\"http://www.w3.org/2005/Atom\" version=\"2.0\"> <channel> <title>Nachrichten - Deutschlandfunk</title> <link>http://www.deutschlandfunk.de/die-nachrichten.353.de.html</link> <atom:link rel=\"self\" type=\"application/rss+xml\" href=\"http://www.deutschlandfunk.de/podcast-nachrichten.1257.de.podcast.xml\"/> <description>Ausgewählte aktuelle Beiträge aus dem Angebot vom Deutschlandfunk</description> <category>Info</category> <copyright>Deutschlandradio - deutschlandradio.de</copyright> <ttl>60</ttl> <language>de-DE</language> <pubDate>Sat, 10 Jun 2017 22:54:27 +0200</pubDate> <lastBuildDate>Sat, 10 Jun 2017 22:54:27 +0200</lastBuildDate> <image> <url>http://www.deutschlandfunk.de/media/files/2/23407846a86cd6b006ea11ace8e0c4a5v3.jpg</url> <title>Nachrichten - Deutschlandfunk</title> <link>http://www.deutschlandfunk.de/die-nachrichten.353.de.html</link> <description>Feed provided by Deutschlandradio. Click to visit.</description> </image> <itunes:subtitle>Die Beiträge zur Sendung</itunes:subtitle> <itunes:image href=\"http://www.deutschlandfunk.de/media/files/2/23407846a86cd6b006ea11ace8e0c4a5v3.jpg\"/> <itunes:new-feed-url>http://www.deutschlandfunk.de/podcast-nachrichten.1257.de.podcast.xml</itunes:new-feed-url> <itunes:owner> <itunes:name>Redaktion deutschlandradio.de</itunes:name> <itunes:email>podcast@deutschlandradio.de</itunes:email> </itunes:owner> <itunes:author>Deutschlandfunk</itunes:author> <itunes:explicit>No</itunes:explicit> <itunes:category text=\"News &amp; Politics\"/> <item> <title>Ersetzter Titel :)</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2200_cb9782bf.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 22:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2200_cb9782bf.mp3</guid> <pubDate>Sat, 10 Jun 2017 22:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2200_cb9782bf.mp3\" length=\"3883289\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>03:59</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2000_e929a4d4.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 20:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2000_e929a4d4.mp3</guid> <pubDate>Sat, 10 Jun 2017 20:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2000_e929a4d4.mp3\" length=\"4206881\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:19</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1900_f0f2b68c.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 19:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1900_f0f2b68c.mp3</guid> <pubDate>Sat, 10 Jun 2017 19:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1900_f0f2b68c.mp3\" length=\"3932495\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:02</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1800_c7bbc91d.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 18:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1800_c7bbc91d.mp3</guid> <pubDate>Sat, 10 Jun 2017 18:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1800_c7bbc91d.mp3\" length=\"8658773\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>08:58</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1700_cd84d8bc.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 17:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1700_cd84d8bc.mp3</guid> <pubDate>Sat, 10 Jun 2017 17:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1700_cd84d8bc.mp3\" length=\"4002968\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:06</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1600_384deedc.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 16:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1600_384deedc.mp3</guid> <pubDate>Sat, 10 Jun 2017 16:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1600_384deedc.mp3\" length=\"4065883\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:10</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1500_8816fd5a.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 15:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1500_8816fd5a.mp3</guid> <pubDate>Sat, 10 Jun 2017 15:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1500_8816fd5a.mp3\" length=\"3653522\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>03:45</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1400_4fe01019.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 14:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1400_4fe01019.mp3</guid> <pubDate>Sat, 10 Jun 2017 14:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1400_4fe01019.mp3\" length=\"4096376\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:12</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1300_caa92043.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 13:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1300_caa92043.mp3</guid> <pubDate>Sat, 10 Jun 2017 13:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1300_caa92043.mp3\" length=\"7553671\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>07:49</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 12:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3</guid> <pubDate>Sat, 10 Jun 2017 12:00:01 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3\" length=\"7673350\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>07:56</itunes:duration> </item> </channel> </rss>";
        public const string NewsPodcastForDuplicatesFilter = "<?xml version=\"1.0\" encoding=\"utf-8\"?> <?xml-stylesheet type=\"text/xsl\" media=\"screen\" href=\"http://www.deutschlandfunk.de/themes/dradio/podcast/podcast.xsl\"?><rss xmlns:itunes=\"http://www.itunes.com/dtds/podcast-1.0.dtd\" xmlns:atom=\"http://www.w3.org/2005/Atom\" version=\"2.0\"> <channel> <title>Nachrichten - Deutschlandfunk</title> <link>http://www.deutschlandfunk.de/die-nachrichten.353.de.html</link> <atom:link rel=\"self\" type=\"application/rss+xml\" href=\"http://www.deutschlandfunk.de/podcast-nachrichten.1257.de.podcast.xml\"/> <description>Ausgewählte aktuelle Beiträge aus dem Angebot vom Deutschlandfunk</description> <category>Info</category> <copyright>Deutschlandradio - deutschlandradio.de</copyright> <ttl>60</ttl> <language>de-DE</language> <pubDate>Sat, 10 Jun 2017 22:54:27 +0200</pubDate> <lastBuildDate>Sat, 10 Jun 2017 22:54:27 +0200</lastBuildDate> <image> <url>http://www.deutschlandfunk.de/media/files/2/23407846a86cd6b006ea11ace8e0c4a5v3.jpg</url> <title>Nachrichten - Deutschlandfunk</title> <link>http://www.deutschlandfunk.de/die-nachrichten.353.de.html</link> <description>Feed provided by Deutschlandradio. Click to visit.</description> </image> <itunes:subtitle>Die Beiträge zur Sendung</itunes:subtitle> <itunes:image href=\"http://www.deutschlandfunk.de/media/files/2/23407846a86cd6b006ea11ace8e0c4a5v3.jpg\"/> <itunes:new-feed-url>http://www.deutschlandfunk.de/podcast-nachrichten.1257.de.podcast.xml</itunes:new-feed-url> <itunes:owner> <itunes:name>Redaktion deutschlandradio.de</itunes:name> <itunes:email>podcast@deutschlandradio.de</itunes:email> </itunes:owner> <itunes:author>Deutschlandfunk</itunes:author> <itunes:explicit>No</itunes:explicit> <itunes:category text=\"News &amp; Politics\"/> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 12:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3</guid> <pubDate>Sun, 11 Jun 2017 12:00:01 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3\" length=\"7673350\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>07:56</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2200_cb9782bf.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 22:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2200_cb9782bf.mp3</guid> <pubDate>Sat, 10 Jun 2017 22:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2200_cb9782bf.mp3\" length=\"3883289\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>03:59</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2000_e929a4d4.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 20:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2000_e929a4d4.mp3</guid> <pubDate>Sat, 10 Jun 2017 20:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_2000_e929a4d4.mp3\" length=\"4206881\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:19</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1900_f0f2b68c.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 19:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1900_f0f2b68c.mp3</guid> <pubDate>Sat, 10 Jun 2017 19:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1900_f0f2b68c.mp3\" length=\"3932495\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:02</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1800_c7bbc91d.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 18:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1800_c7bbc91d.mp3</guid> <pubDate>Sat, 10 Jun 2017 18:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1800_c7bbc91d.mp3\" length=\"8658773\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>08:58</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1700_cd84d8bc.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 17:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1700_cd84d8bc.mp3</guid> <pubDate>Sat, 10 Jun 2017 17:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1700_cd84d8bc.mp3\" length=\"4002968\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:06</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1600_384deedc.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 16:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1600_384deedc.mp3</guid> <pubDate>Sat, 10 Jun 2017 16:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1600_384deedc.mp3\" length=\"4065883\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:10</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1500_8816fd5a.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 15:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1500_8816fd5a.mp3</guid> <pubDate>Sat, 10 Jun 2017 15:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1500_8816fd5a.mp3\" length=\"3653522\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>03:45</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1400_4fe01019.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 14:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1400_4fe01019.mp3</guid> <pubDate>Sat, 10 Jun 2017 14:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1400_4fe01019.mp3\" length=\"4096376\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>04:12</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1300_caa92043.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 13:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1300_caa92043.mp3</guid> <pubDate>Sat, 10 Jun 2017 13:00:00 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1300_caa92043.mp3\" length=\"7553671\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>07:49</itunes:duration> </item> <item> <title>Nachrichten</title> <link>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3</link> <description><![CDATA[Autor: Deutschlandfunk-Nachrichtenredaktion<br/>Sendung: <a href=\"http://www.deutschlandfunk.de/nachrichten.353.de.html\">Nachrichten</a><br/>Hören bis: 17.06.2017 12:00<br/><br/>]]></description> <guid>http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3</guid> <pubDate>Sat, 10 Jun 2017 12:00:01 +0200</pubDate> <enclosure url=\"http://podcast-mp3.dradio.de/podcast/2017/06/10/nachrichten_dlf_20170610_1200_b1722a12.mp3\" length=\"7673350\" type=\"audio/mpeg\"/> <itunes:author>Deutschlandfunk-Nachrichtenredaktion</itunes:author> <itunes:duration>07:56</itunes:duration> </item> </channel> </rss>";

        public static XDocument CreateSampleNewsPodcastForStringFilter()
        {
            return XDocument.Parse(NewsPodcastForStringFilter);
        }

        public static XDocument CreateSampleNewsPodcastWithDuplicates()
        {
            return XDocument.Parse(NewsPodcastForDuplicatesFilter);
        }
    }
}
