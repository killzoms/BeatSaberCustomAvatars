using System;
using CustomAvatar.Utilities;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CustomAvatar
{
	public class SpawnedAvatar
	{
		public CustomAvatar customAvatar { get; }
		public AvatarBehaviour behaviour { get; }
		public AvatarEventsPlayer eventsPlayer { get; }

        private readonly GameObject _gameObject;

        public SpawnedAvatar(CustomAvatar customAvatar)
        {
            this.customAvatar = customAvatar ?? throw new ArgumentNullException(nameof(customAvatar));
            _gameObject = Object.Instantiate(customAvatar.gameObject);

            eventsPlayer = _gameObject.AddComponent<AvatarEventsPlayer>();
            behaviour = _gameObject.AddComponent<AvatarBehaviour>();

            Object.DontDestroyOnLoad(_gameObject);
        }

        public void Destroy()
        {
	        Object.Destroy(_gameObject);
        }

        public void OnFirstPersonEnabledChanged()
        {
	        SetChildrenToLayer(SettingsManager.settings.isAvatarVisibleInFirstPerson ? AvatarLayers.AlwaysVisible : AvatarLayers.OnlyInThirdPerson);
        }

        private void SetChildrenToLayer(int layer)
        {
	        foreach (var child in _gameObject.GetComponentsInChildren<Transform>())
	        {
		        child.gameObject.layer = layer;
	        }
        }
    }
}
