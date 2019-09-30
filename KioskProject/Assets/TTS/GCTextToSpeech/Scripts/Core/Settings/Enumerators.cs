namespace FrostweepGames.Plugins.GoogleCloud.TextToSpeech
{
    public class Enumerators
    {
        public enum GoogleCloudRequestType
        {
            GET_VOICES,
            SYNTHESIZE
        }

        public enum SsmlVoiceGender
        {
            SSML_VOICE_GENDER_UNSPECIFIED,
            MALE,
            FEMALE,
            NEUTRAL
        }

        public enum AudioEncoding
        {
            AUDIO_ENCODING_UNSPECIFIED,
            LINEAR16,
            MP3,
            OGG_OPUS
        }

        public enum LanguageCode
        {
            ko_KR
        }

        public enum VoiceType
        {
            WAVENET,
            STANDARD
        }
    }
}