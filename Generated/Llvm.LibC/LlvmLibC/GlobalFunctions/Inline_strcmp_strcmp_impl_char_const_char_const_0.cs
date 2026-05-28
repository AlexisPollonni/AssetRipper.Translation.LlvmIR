using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_strcmp_strcmp_impl_char_const_char_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13inline_strcmpIRZNS_15__strcmp_impl__EPKcS2_E3$_0EEiS2_S2_OT_")]
	[DemangledName("int __llvm_libc_20_1_2_::inline_strcmp<__llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&>(char const*, char const*, __llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("left")][NativeType("char const*")] void* Left, [MangledName("right")][NativeType("char const*")] void* Right, [MangledName("comp")][NativeType("__llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&")] void* Comp)
	{
		void* ptr = Left;
		void* ptr2 = Right;
		unchecked
		{
			while (*(bool*)ptr && InstructionHelper.BooleanXor(_0_Invoke_r59jtm.Invoke(Comp, *(sbyte*)ptr, *(sbyte*)ptr2) != 0, right: true))
			{
				ptr = (byte*)ptr + 1;
				ptr2 = (byte*)ptr2 + 1;
			}
			return _0_Invoke_r59jtm.Invoke(Comp, *(sbyte*)ptr, *(sbyte*)ptr2);
		}
	}
}
