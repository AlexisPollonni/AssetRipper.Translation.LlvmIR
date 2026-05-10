using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5MutexC2Ebbbb")]
[DemangledName("__llvm_libc_20_1_2_::Mutex::Mutex(bool, bool, bool, bool)")]
internal static partial class Mutex_Mutex_bool_bool_bool_bool
{
	public unsafe static void Invoke(void* @this, bool is_timed, bool is_recursive, bool is_robust, bool is_pshared)
	{
		sbyte b = (is_timed ? ((sbyte)1) : ((sbyte)0));
		sbyte b2 = (is_recursive ? ((sbyte)1) : ((sbyte)0));
		sbyte b3 = (is_robust ? ((sbyte)1) : ((sbyte)0));
		sbyte b4 = (is_pshared ? ((sbyte)1) : ((sbyte)0));
		RawMutex_RawMutex.Invoke(@this);
		unchecked
		{
			((LlvmLibC.Structures.Mutex*)@this)->timed = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((LlvmLibC.Structures.Mutex*)@this)->recursive = (((b2 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((LlvmLibC.Structures.Mutex*)@this)->robust = (((b3 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((LlvmLibC.Structures.Mutex*)@this)->pshared = (((b4 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((LlvmLibC.Structures.Mutex*)@this)->owner = 0;
			((LlvmLibC.Structures.Mutex*)@this)->lock_count = 0L;
		}
	}
}
