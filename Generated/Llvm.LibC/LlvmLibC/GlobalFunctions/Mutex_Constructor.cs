using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mutex_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5MutexC2Ebbbb")]
	[DemangledName("__llvm_libc_20_1_2_::Mutex::Mutex(bool, bool, bool, bool)")]
	public unsafe static void Invoke(LlvmLibC.Structures.Mutex* @this, [NativeType("bool")] bool is_timed, [NativeType("bool")] bool is_recursive, [NativeType("bool")] bool is_robust, [NativeType("bool")] bool is_pshared)
	{
		sbyte b = (is_timed ? ((sbyte)1) : ((sbyte)0));
		sbyte b2 = (is_recursive ? ((sbyte)1) : ((sbyte)0));
		sbyte b3 = (is_robust ? ((sbyte)1) : ((sbyte)0));
		sbyte b4 = (is_pshared ? ((sbyte)1) : ((sbyte)0));
		RawMutex_Constructor.Invoke(@this);
		@this->timed = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		@this->recursive = (((b2 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		@this->robust = (((b3 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		@this->pshared = (((b4 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		@this->owner = 0;
		@this->lock_count = 0L;
	}
}
