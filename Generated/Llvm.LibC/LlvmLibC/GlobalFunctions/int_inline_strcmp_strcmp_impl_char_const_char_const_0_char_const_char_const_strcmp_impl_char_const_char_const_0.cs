using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13inline_strcmpIRZNS_15__strcmp_impl__EPKcS2_E3$_0EEiS2_S2_OT_")]
[DemangledName("int __llvm_libc_20_1_2_::inline_strcmp<__llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&>(char const*, char const*, __llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0&)")]
internal static partial class int_inline_strcmp_strcmp_impl_char_const_char_const_0_char_const_char_const_strcmp_impl_char_const_char_const_0
{
	public unsafe static int Invoke(void* left, void* right, void* comp)
	{
		void* ptr = left;
		void* ptr2 = right;
		unchecked
		{
			while (*(bool*)ptr && (((strcmp_impl_char_const_char_const_0_operator_char_char_const.Invoke(comp, *(sbyte*)ptr, *(sbyte*)ptr2) != 0) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
			{
				ptr = (byte*)ptr + 1;
				ptr2 = (byte*)ptr2 + 1;
			}
			return strcmp_impl_char_const_char_const_0_operator_char_char_const.Invoke(comp, *(sbyte*)ptr, *(sbyte*)ptr2);
		}
	}
}
