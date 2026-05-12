using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class vasprintf
{
	public unsafe static int Invoke(void* ret, void* format, va_list_tag* vlist)
	{
		internal_ArgList internal_ArgList2 = default(internal_ArgList);
		internal_ArgList internal_ArgList3 = default(internal_ArgList);
		llvm_lifetime_start_p0.Invoke(24L, &internal_ArgList2);
		unchecked
		{
			va_list_tag* ptr = (va_list_tag*)(&internal_ArgList2);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			internal_ArgList_ArgList_va_list_tag.Invoke(&internal_ArgList2, vlist);
			internal_ArgList_ArgList_internal_ArgList.Invoke(&internal_ArgList3, &internal_ArgList2);
			int result = printf_core_vasprintf_internal_char_char_const_internal_ArgList.Invoke(ret, format, &internal_ArgList3);
			internal_ArgList_ArgList.Invoke(&internal_ArgList3);
			internal_ArgList_ArgList.Invoke(&internal_ArgList2);
			llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList2);
			return result;
		}
	}
}
