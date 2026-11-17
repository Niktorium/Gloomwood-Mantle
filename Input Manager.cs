using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // для использования нужно создать input actions и назначить действия
    #region Variables
    public static InputManager IM;
    public PlayerInput playerInput;

    [Header("Walking")]
    [SerializeField] private string MoveActionName;
    [SerializeField] private string JumpActionName;
    [SerializeField] private string RunActionName;
    [SerializeField] private string CrouchActionName;
    [SerializeField] private string ProneActionName;
    [SerializeField] private string MantleActionName;

    public InputAction MoveAction;
    public InputAction JumpAction;
    public InputAction RunAction;
    public InputAction CrouchAction;
    public InputAction ProneAction;
    public InputAction MantleAction;

    public Vector3 MoveDir;
    #endregion


    #region Unity Methods
    private void Start()
    {
        IM = this;
        InitializeActions();
    }

    void Update()
    {
        ReadValues();
    }
    #endregion


    #region Input action methods
    private void InitializeActions()
    {
        MoveAction = playerInput.actions.FindAction(MoveActionName);
        JumpAction = playerInput.actions.FindAction(JumpActionName);
        RunAction = playerInput.actions.FindAction(RunActionName);
        CrouchAction = playerInput.actions.FindAction(CrouchActionName);
        ProneAction = playerInput.actions.FindAction(ProneActionName);
        MantleAction = playerInput.actions.FindAction(MantleActionName);
    }

    private void ReadValues()
    {
        MoveDir = MoveAction.ReadValue<Vector3>();
    }
    #endregion
}