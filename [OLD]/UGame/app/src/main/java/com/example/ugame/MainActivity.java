package com.example.ugame;

import android.os.Handler;
import android.os.SystemClock;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.view.View;
import android.support.v4.view.GravityCompat;
import android.support.v7.app.ActionBarDrawerToggle;
import android.view.MenuItem;
import android.support.design.widget.NavigationView;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.widget.Button;
import android.widget.TextView;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

    ListView listView;
    TextView timer, gameTitle;
    Button start, pause, reset;
    long MillisecondTime, StartTime, TimeBuff, UpdateTime = 0L;
    Handler handler;
    int Seconds, Minutes, MilliSeconds, Hours;
    boolean tracking = false;
    boolean paused = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listView = (ListView)findViewById(R.id.listview);
        final ArrayList<String> gameList = new ArrayList<>();

        gameList.add("MARVEL Strike Force");
        gameList.add("Super Smash Bros. Ultimate");

        ArrayAdapter arrayAdapter = new ArrayAdapter(this, android.R.layout.simple_list_item_1,gameList);
        listView.setAdapter(arrayAdapter);

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Toast.makeText(MainActivity.this, "Game time.", Toast.LENGTH_SHORT).show();
                setContentView(R.layout.game_details);

                gameTitle = (TextView)findViewById(R.id.tvGameTitle);
                timer = (TextView)findViewById(R.id.tvTimer);
                start = (Button)findViewById(R.id.btStart);
                pause = (Button)findViewById(R.id.btPause);
                reset = (Button)findViewById(R.id.btReset);
                reset.setEnabled(false);
                pause.setEnabled(false);

                gameTitle.setText(gameList.get(position).toString());

                handler = new Handler() ;

                start.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        if (tracking == false)
                        {
                            StartTime = SystemClock.uptimeMillis();
                            handler.postDelayed(runnable, 0);

                            reset.setEnabled(true);
                            pause.setEnabled(true);
                            start.setText("STOP");
                            tracking = true;
                        }
                        else
                        {
                            StartTime = 0;
                            handler.postDelayed(runnable, 0);

                            Toast.makeText(MainActivity.this, timer.getText() + " Played", Toast.LENGTH_SHORT).show();

                            TimeBuff += MillisecondTime;
                            handler.removeCallbacks(runnable);
                            MillisecondTime = 0L ;
                            StartTime = 0L ;
                            TimeBuff = 0L ;
                            UpdateTime = 0L ;
                            Seconds = 0 ;
                            Minutes = 0 ;
                            MilliSeconds = 0 ;

                            timer.setText("00:00:00");
                            reset.setEnabled(false);
                            pause.setEnabled(false);

                            start.setText("TRACK");
                            pause.setText("PAUSE");

                            tracking = false;
                        }

                    }
                });

                pause.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        if (paused == false)
                        {
                            TimeBuff += MillisecondTime;

                            handler.removeCallbacks(runnable);

                            pause.setText("RESUME");

                            paused = true;
                        }
                        else
                        {
                            pause.setText("PAUSE");
                            paused = false;
                        }
                    }
                });

                reset.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {

                        TimeBuff += MillisecondTime;
                        handler.removeCallbacks(runnable);
                        MillisecondTime = 0L ;
                        StartTime = 0L ;
                        TimeBuff = 0L ;
                        UpdateTime = 0L ;
                        Seconds = 0 ;
                        Minutes = 0 ;
                        MilliSeconds = 0 ;

                        timer.setText("00:00:00");
                        reset.setEnabled(false);
                        pause.setEnabled(false);

                        start.setText("TRACK");
                        pause.setText("PAUSE");

                        tracking = false;
                        paused = false;
                    }
                });
            }
        });

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });
        DrawerLayout drawer = findViewById(R.id.drawer_layout);
        NavigationView navigationView = findViewById(R.id.nav_view);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.addDrawerListener(toggle);
        toggle.syncState();
        navigationView.setNavigationItemSelectedListener(this);
    }

    public Runnable runnable = new Runnable() {

        public void run() {

            MillisecondTime = SystemClock.uptimeMillis() - StartTime;

            UpdateTime = TimeBuff + MillisecondTime;

            Seconds = (int) (UpdateTime / 1000);

            Minutes = Seconds / 60;

            Seconds = Seconds % 60;

            Hours = Minutes / 60;

            Minutes = Minutes % 60;

            MilliSeconds = (int) (UpdateTime % 1000);

            timer.setText(String.format("%02d", Hours) + ":"
                    + String.format("%02d", Minutes) + ":"
                    + String.format("%02d", Seconds));

            handler.postDelayed(this, 0);
        }

    };

    @Override
    public void onBackPressed() {
        DrawerLayout drawer = findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

        if (id == R.id.nav_home) {
            // Handle the camera action
        } else if (id == R.id.nav_gallery) {

        } else if (id == R.id.nav_slideshow) {

        } else if (id == R.id.nav_tools) {

        } else if (id == R.id.nav_share) {

        } else if (id == R.id.nav_send) {

        }

        DrawerLayout drawer = findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }
}
