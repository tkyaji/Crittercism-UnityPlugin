//
//  CrittercismPlugin.mm
//  Unity-iPhone
//
//  Created by tkyaji on 2016/08/18.
//
//

#import <Crittercism/Crittercism.h>

#ifdef __cplusplus
extern "C" {
#endif
    
    void _CrittercismPlugin_initialize(const char *appId) {
        [Crittercism enableWithAppID:[NSString stringWithUTF8String:appId]];
    }
    
#ifdef __cplusplus
}
#endif
