using Facebook;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookTest
{
    public partial class Form1 : Form
    {
        List<Posts> listAllPosts = new List<Posts>();
        List<PageReactionInfo> listAllPostsInfo = new List<PageReactionInfo>();

        FacebookClient client;
        System.Threading.Timer fbTimer;
        string page = "174320072640334";
        string appId = "1591918864261687";
        string appSecret = "6258189e76e026b6d3635f847a49b45b";

        private int counter = 10;

        public Form1()
        {
            InitializeComponent();
            client = getAccessToken();
            GetAllPosts();
            getAllPostInfo();
            InitTimer();
        }

        private void TimerCallback(Object o)
        {
            client = new FacebookClient(appId + "|" + appSecret);
        }

        //Facebook token
        public FacebookClient getAccessToken()
        {
            try
            {
                client = new FacebookClient(appId + "|" + appSecret);
                // update access token every ½ hour.
                fbTimer = new System.Threading.Timer(TimerCallback, null, 0, (1000 * 60) * 30);

                return client;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //Sets up the FacebookClients Access Token using the App ID & App Secret.


        public List<Posts> GetAllPosts()
        {
            dynamic result = client.Get("v2.11/" + page + "/posts?fields=message");
            for (int i = 0; i < result.data.Count; i++)
            {
                Posts posts = new Posts();

                posts.id = result.data[i].id;
                posts.message = result.data[i].message;
                listAllPosts.Add(posts);

                lbPosts.Items.Add(posts.id);
            }
            lblTotalPosts.Text = listAllPosts.Count.ToString();
            return listAllPosts;
        }

        public PageReactionInfo getAllInfo()
        {
            PageReactionInfo postInfo = new PageReactionInfo();
            foreach (var post in listAllPosts)
            {
                dynamic result = client.Get("v2.11/" + post.id + "?fields=reactions.type(LIKE).summary(total_count).limit(0).as(like),reactions.type(LOVE).summary(total_count).limit(0).as(love), reactions.type(WOW).summary(total_count).limit(0).as(wow), reactions.type(HAHA).summary(total_count).limit(0).as(haha), reactions.type(SAD).summary(total_count).limit(0).as(sad), reactions.type(ANGRY).summary(total_count).limit(0).as(angry), reactions.type(THANKFUL).summary(total_count).limit(0).as(thankful)");
                postInfo.TotalLike += result.like.summary.total_count;
                postInfo.TotalLove += result.love.summary.total_count;
                postInfo.TotalWow += result.wow.summary.total_count;
                postInfo.TotalHaha += result.haha.summary.total_count;
                postInfo.TotalSad += result.sad.summary.total_count;
                postInfo.TotalAngry += result.angry.summary.total_count;
                postInfo.TotalThankful += result.thankful.summary.total_count;
            }

            return postInfo;
        }

        public List<PageReactionInfo> getAllPostInfo()
        {
            foreach (var post in listAllPosts)
            {
                PageReactionInfo postInfo = new PageReactionInfo();
                dynamic result = client.Get("v2.11/" + post.id + "?fields=reactions.type(LIKE).summary(total_count).limit(0).as(like),reactions.type(LOVE).summary(total_count).limit(0).as(love), reactions.type(WOW).summary(total_count).limit(0).as(wow), reactions.type(HAHA).summary(total_count).limit(0).as(haha), reactions.type(SAD).summary(total_count).limit(0).as(sad), reactions.type(ANGRY).summary(total_count).limit(0).as(angry), reactions.type(THANKFUL).summary(total_count).limit(0).as(thankful)");
                postInfo.TotalLike = result.like.summary.total_count;
                postInfo.TotalLove = result.love.summary.total_count;
                postInfo.TotalWow = result.wow.summary.total_count;
                postInfo.TotalHaha = result.haha.summary.total_count;
                postInfo.TotalSad = result.sad.summary.total_count;
                postInfo.TotalAngry = result.angry.summary.total_count;
                postInfo.TotalThankful = result.thankful.summary.total_count;
                postInfo.Id = 1;
                postInfo.PostId = post.id;
                postInfo.DateTime = DateTime.Now;
                listAllPostsInfo.Add(postInfo);
            }
            return listAllPostsInfo;
        }


        public async Task setlabels()
        {
            await Task.Delay(0);
            PageReactionInfo postInfo1 = new PageReactionInfo();
            postInfo1 = getAllInfo();

            lblTotalLikes.Text = postInfo1.TotalLike.ToString();
            lblTotalLove.Text = postInfo1.TotalLove.ToString();
            lblTotalWow.Text = postInfo1.TotalWow.ToString();
            lblTotalHaha.Text = postInfo1.TotalHaha.ToString();
            lblTotalSad.Text = postInfo1.TotalSad.ToString();
            lblTotalAngry.Text = postInfo1.TotalAngry.ToString();
            lblTotalThanks.Text = postInfo1.TotalThankful.ToString();

            GC.Collect();
        }




        /////////////////////////////////////////////////////////////////////
        //////////////////////////// BUTTONS ////////////////////////////////
        /////////////////////////////////////////////////////////////////////

        private void lbPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listAllPostsInfo)
            {

                if (lbPosts.SelectedItem.ToString() == item.PostId)
                {
                    foreach (var item1 in listAllPosts)
                    {
                        if (lbPosts.SelectedItem.ToString() == item1.id)
                        {
                            lblMessage.Text = item1.message;
                        }
                    }
                    lblLikes1.Text = item.TotalLike.ToString();
                    lblLove1.Text = item.TotalLove.ToString();
                    lblWow1.Text = item.TotalWow.ToString();
                    lblHaha1.Text = item.TotalHaha.ToString();
                    lblSad1.Text = item.TotalSad.ToString();
                    lblAngry1.Text = item.TotalAngry.ToString();
                    lblThankf1.Text = item.TotalThankful.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAppId.Text) && string.IsNullOrWhiteSpace(tbAppSecret.Text))
            {
                string error = "ERROR!";
            }
            else
            {
                appId = tbAppId.Text;
                appSecret = tbAppSecret.Text;

                lblAppId1.Visible = false;
                lblAppSecret1.Visible = false;
                tbAppSecret.Visible = false;
                tbAppId.Visible = false;
                btnAdd.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        /////////////////////////////////////////////////////////////////////
        ////////////////////////////// Timer ////////////////////////////////
        /////////////////////////////////////////////////////////////////////


        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick_1);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lblCount.Text = counter.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter = counter - 1;
                lblCount.Text = counter.ToString();
            }
            else
            {
                Task task = setlabels();
                task.Wait();
                counter = 10;
                lblCount.Text = counter.ToString();
            }
        }





        /////////////////////////////////////////////////////////////////////
        /////////////////////////////// Test ////////////////////////////////
        /////////////////////////////////////////////////////////////////////

        public void ThisIsATest()
        {
            //Get Request
            //dynamic result = facebookClient.Get(version + page + "/posts?fields=message");
            //dynamic result = facebookClient.Get(version + page + "?fields=business");
            //dynamic result = facebookClient.Get(version + page + "_" + post + "/reactions");
            //dynamic result = facebookClient.Get(version + page + "_" + post + "/reactions?summary=total_count");
            //dynamic result = facebookClient.Get(version + page + "_" + post + "?fields=likes");
            //dynamic result = facebookClient.Get(version + page + "?fields=country_page_likes");  
            //dynamic result = facebookClient.Get("v2.11" + page + "_" + post + "?fields=created_time,story,message,shares,reactions.type(LIKE).limit(0).summary(1).as(like),reactions.type(LOVE).limit(0).summary(1).as(love),reactions.type(HAHA).limit(0).summary(1).as(haha),reactions.type(WOW).limit(0).summary(1).as(wow),reactions.type(SAD).limit(0).summary(1).as(sad),reactions.type(ANGRY).limit(0).summary(1).as(angry)&limit=10");
            //dynamic result = facebookClient.Get(version + page + "_" + post + "?fields=insights.metric(post_reactions_by_type_total).period(lifetime).as(post_reactions_by_type_total)");
            //dynamic result = facebookClient.Get(version + page + "?fields=visitor_posts");
            //dynamic result = facebookClient.Get(version + page + "?fields=fan_count");
            //dynamic result = facebookClient.Get(version + page + "?fields=were_here_count");
            //dynamic result = facebookClient.Get(version + page + "?fields=talking_about_count");
        }


    }


}

