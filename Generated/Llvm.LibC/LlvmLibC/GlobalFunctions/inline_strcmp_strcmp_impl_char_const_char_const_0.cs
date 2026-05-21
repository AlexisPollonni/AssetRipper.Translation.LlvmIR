using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_strcmp_strcmp_impl_char_const_char_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13inline_strcmpIRZNS_15__strcmp_impl__EPKcS2_E3$_0EEiS2_S2_OT_")]
	[DemangledName("int __llvm_libc_20_1_2_::inline_strcmp<__llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&>(char const*, char const*, __llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("char const*")] void* left, [NativeType("char const*")] void* right, [NativeType("__llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&")] void* comp)
	{
		void* ptr = left;
		void* ptr2 = right;
		unchecked
		{
			while (*(bool*)ptr && (((_0_Invoke_r59jtm.Invoke(comp, *(sbyte*)ptr, *(sbyte*)ptr2) != 0) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
			{
				ptr = (byte*)ptr + 1;
				ptr2 = (byte*)ptr2 + 1;
			}
			return _0_Invoke_r59jtm.Invoke(comp, *(sbyte*)ptr, *(sbyte*)ptr2);
		}
	}
}
