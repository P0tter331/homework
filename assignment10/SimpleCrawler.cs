using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler {
  class SimpleCrawler {
    private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();

    private int count = 0;
    static void Main(string[] args) {
      SimpleCrawler myCrawler = new SimpleCrawler();
      string startUrl = "http://www.cnblogs.com/dstang2000/";
      if (args.Length >= 1) startUrl = args[0];
      myCrawler.urls.Add(startUrl, false);//加入初始页面
      new Thread(myCrawler.Crawl).Start();
    }

    private void Crawl()
    {
        Console.WriteLine("开始爬行了.... ");
        while (true)
        {
            List<string> toCrawl = new List<string>();
            foreach (string url in urls.Keys.Cast<string>().Where(url => !(bool)urls[url]))
            {
                toCrawl.Add(url);
                if (toCrawl.Count >= 10) break; // 限制并行处理的数量，避免过载
            }

            if (!toCrawl.Any() || count >= 10) break;

            Parallel.ForEach(toCrawl, new ParallelOptions { MaxDegreeOfParallelism = 10 }, current => {
                Console.WriteLine("爬行 " + current + " 页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                Interlocked.Increment(ref count);
                Parse(html); // 解析, 并加入新的链接
            });

            Console.WriteLine("本轮爬行结束");
        }
    }




    public string DownLoad(string url)
    {
        try
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            // 使用线程ID或时间戳创建唯一文件名
            string fileName = $"{Thread.CurrentThread.ManagedThreadId}-{count}.html";
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "";
        }
    }

    private void Parse(string html)
    {
        string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
        MatchCollection matches = new Regex(strRef).Matches(html);
        foreach (Match match in matches)
        {
            strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
            if (strRef.Length == 0) continue;
            urls.TryAdd(strRef, false); // 使用 TryAdd 确保线程安全
        }
    }
   }
}
