
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status { get; private set; }

    [SerializeField] private GameObject Player;

    #region States
    private StateMachine stateMachine;
    public PlayerIdleState IdleState { get; private set; }
    public PlayerWalkState WalkState { get; private set; }
    public PlayerRunState RunState { get; private set; }
    public PlayerDodgeState DodgeState { get; private set; }
    public PlayerFallState FallingState { get; private set; }
    #endregion

    #region Movement and input
    public MovementHandler MoveHandler { get; private set; }
    public PlayerInputHandler InputHandler { get; private set; }
    public PlayerMovement Movement { get; private set; }
    private PlayerFall FallMovement { get; set; }
    public PlayerDodge DodgeMovement { get; private set; }
    public PlayerRotation Rotation { get; private set; }
    #endregion

    #region Controllers

    public PlayerData playerData;
    public PlayerHealth Health { get; private set; }
    public AttackController Weapon { get; private set; }

    public WeaponSwitch WeaponSwitcher { get; private set; }
    #endregion

    public void Startup()
    {
        Debug.Log("Player manager starting...");        

        // Creates new object of the player state machine
        stateMachine = new PlayerStateMachine();

        // Create new objects of all states
        IdleState = new PlayerIdleState(this, stateMachine);
        WalkState = new PlayerWalkState(this, stateMachine);
        RunState = new PlayerRunState(this, stateMachine);
        DodgeState = new PlayerDodgeState(this, stateMachine);
        FallingState = new PlayerFallState(this, stateMachine);

        Health = Player.GetComponent<PlayerHealth>();
        MoveHandler = Player.GetComponent<MovementHandler>();
        InputHandler = Player.GetComponent<PlayerInputHandler>();
        Movement = Player.GetComponent<PlayerMovement>();
        FallMovement = Player.GetComponent<PlayerFall>();
        DodgeMovement = Player.GetComponent<PlayerDodge>();
        Rotation = Player.GetComponent<PlayerRotation>();
        Weapon = Player.GetComponent<AttackController>();
        WeaponSwitcher = Player.GetComponent<WeaponSwitch>();

        stateMachine.Initialize(IdleState);

        status = ManagerStatus.Started;
    }

    // Update is called once per frame
    void Update()
    {
        // Player aim rotation
        Rotation.HandleRotation();

        // Player horizontal movement vector
        Movement.MovementDirection();

        // Player vertical movement vector
        FallMovement.Gravity();

        // Player switching weapon input
        WeaponSwitcher.OnSwichWeaponInput();

        stateMachine.CurrentState.LogicUpdate();

        //Debug.Log(stateMachine.CurrentState.ToString());
    }

    // FixedUpdate is called once per physics calculation
    void FixedUpdate()
    {
        // Moves player adding up all the movement vector's
        MoveHandler.Move();
    }

}
